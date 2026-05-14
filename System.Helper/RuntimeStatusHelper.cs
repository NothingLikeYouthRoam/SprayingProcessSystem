using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace System.Helper
{
    public class RuntimeStatusHelper
    {
        /// <summary>
        /// 唯一实例
        /// </summary>
        public readonly static RuntimeStatusHelper DataManager = new RuntimeStatusHelper();

        private PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");//保持一个cpu实例，避免重复创建

        //定义内存的信息结构
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_INFO
        {
            public uint dwLength; //当前结构体大小
            public uint dwMemoryLoad; //当前内存使用率
            public ulong ullTotalPhys; //总计物理内存大小
            public ulong ullAvailPhys; //可用物理内存大小
            public ulong ullTotalPageFile; //总计交换文件大小
            public ulong ullAvailPageFile; //总计交换文件大小
            public ulong ullTotalVirtual; //总计虚拟内存大小
            public ulong ullAvailVirtual; //可用虚拟内存大小
            public ulong ullAvailExtendedVirtual; //保留 这个值始终为0
        }

        [DllImport("kernel32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref MEMORY_INFO mi);//获取内存相关数据

        /// <summary> 
        /// 构造方法 
        /// </summary>     
        private RuntimeStatusHelper()
        {
            cpu.NextValue();//因为第一次获取CPU使用率总是0，所以在此获取一次CPU使用率，避免画面显示CPU为0的情况
        }


        /// <summary>
        /// 获取电脑磁盘剩余空间
        /// </summary>
        /// <returns></returns>
        public string GetDrivers()
        {
            string result = "";
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (!drive.IsReady)
                    continue;
                if (result.Length > 0) result += ",";
                result += string.Format("{0}盘剩余{1}", drive.Name.Split(':')[0] + "盘剩余", FormatSize(drive.TotalFreeSpace));
            }
            return result;
        }
        /// <summary>
        /// 获取电脑IP地址
        /// </summary>
        /// <returns></returns>
        public string GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] iPs = Dns.GetHostEntry(hostName).AddressList;
            foreach (IPAddress ip in iPs)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }


        /// <summary>
        /// 获取CPU实时占用率
        /// </summary>
        /// <returns></returns>
        public string GetCpuUtilization()
        {
            return String.Format("{0}", cpu.NextValue());
        }

        /// <summary>
        /// 获取内存实时占用率
        /// </summary>
        /// <returns></returns>
        public string GetMemoryUtilization()
        {
            return String.Format("{0}/{1}", FormatSize(GetUsedPhys()), FormatSize(GetTotalPhys()));
        }

        /// <summary>
        /// 格式化容量大小
        /// </summary>
        /// <param name="size">容量（B）</param>
        /// <returns>已格式化的容量</returns>
        private string FormatSize(double size)
        {
            double d = (double)size;
            int i = 0;
            while ((d > 1024) && (i < 5))
            {
                d /= 1024;
                i++;
            }
            string[] unit = { "B", "KB", "MB", "G", "T" };
            return (string.Format("{0} {1}", Math.Round(d, 2), unit[i]));
        }

        /// <summary>
        /// 获得当前内存使用情况
        /// </summary>
        /// <returns></returns>
        public MEMORY_INFO GetMemoryStatus()
        {
            MEMORY_INFO mi = new MEMORY_INFO();
            mi.dwLength = (uint)Marshal.SizeOf(mi);
            GlobalMemoryStatusEx(ref mi);
            return mi;
        }

        /// <summary>
        /// 获得当前可用物理内存大小
        /// </summary>
        /// <returns>当前可用物理内存（B）</returns>
        public ulong GetAvailPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return mi.ullAvailPhys;
        }

        /// <summary>
        /// 获得当前已使用的内存大小
        /// </summary>
        /// <returns>已使用的内存大小（B）</returns>
        public ulong GetUsedPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return (mi.ullTotalPhys - mi.ullAvailPhys);
        }

        /// <summary>
        /// 获得当前总计物理内存大小
        /// </summary>
        /// <returns&amp;gt;总计物理内存大小（B）&amp;lt;/returns&amp;gt;
        public ulong GetTotalPhys()
        {
            MEMORY_INFO mi = GetMemoryStatus();
            return mi.ullTotalPhys;
        }
        public string GetTurnonTime()
        {
            return DateTime.Now.AddMilliseconds(-Environment.TickCount).ToString();
        }
    }
}
