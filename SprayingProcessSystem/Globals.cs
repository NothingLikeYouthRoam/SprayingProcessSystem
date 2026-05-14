using IoTClient.Clients.PLC;
using IoTClient.Enums;
using IoTClient.Common.Enums;
using Microsoft.Extensions.DependencyInjection;
using Sunny.UI;

namespace SprayingProcessSystem
{
    internal class Globals
    {
        // 依赖注入服务提供者，全局访问已注册的服务实例
        public static ServiceProvider serviceProvider;
        // INI配置文件读写工具，指向程序目录下的config.ini
        public static IniFile ini = new IniFile(Application.StartupPath + "\\config.ini");
        // PLC变量配置表(Excel)的文件路径
        public static string PlcVarConfigPath;
        // 西门子PLC通信客户端
        public static SiemensClient SiemensClient;
        // CPU类型（如S7-1200、S7-1500等）
        public static SiemensVersion CpuType;
        // PLC的IP地址
        public static string IpAddress;
        // PLC的端口号
        public static int Port;
        // 插槽号
        public static byte Slot;
        // 机架号
        public static byte Rack;
        // PLC连接超时时间（毫秒）
        public static int ConnectTimeOut;
        // PLC读取间隔时间（毫秒），定时轮询读取变量值的间隔
        public static int ReadTimeInterval;
        // PLC重连时间间隔（毫秒），连接断开后自动重试的间隔
        public static int ReConnectTimeInterval;
        // 【读取用】键是PLC地址(如"DB1.0")，值是数据类型(如Float、Int16)
        // 例：ReadDic["DB1.0"] = DataTypeEnum.Float → 程序知道去DB1.0读一个Float类型的数据
        public static Dictionary<string, DataTypeEnum> ReadDic = new Dictionary<string, DataTypeEnum>();
        // 【显示用】键是变量名称(如"温度")，值是从PLC读回来的最新数据
        // 例：DataDic["温度"] = 25.6 → 界面上显示温度值
        public static Dictionary<string, object> DataDic = new Dictionary<string, object>();
        // 【写入用】键是变量名称(如"温度")，值是PLC地址(如"DB1.0")
        // 例：WriteDic["温度"] = "DB1.0" → 用户在界面修改温度时，通过名称找到地址写入PLC
        public static Dictionary<string, string> WriteDic = new Dictionary<string, string>();
        // 需要保存的PLC变量集合
        public static List<string> SaveList = new List<string>();

        public static string DelFilePath;

        public static string SaveDay;
        public static string SoftWareVersion;
        public static string SYTime;

        public static bool PlcWrite(string varName, object value, DataTypeEnum dataType=DataTypeEnum.Bool)
        {
            if (SiemensClient.Connected)
            {
                var address = WriteDic[varName];
                var res = SiemensClient.Write(address, value, dataType);
                if (res.IsSucceed)
                {
                    return true;
                }
            }
            return false;
        }

        #region 获取所有控件
        // 获取指定页面的所有控件
        public static List<Control> GetAllControls(UIPage page)
        {
            List<Control> allControls = new List<Control>();
            CollectControls(page.Controls, allControls);
            return allControls;
        }

        // 递归方法，用于收集控件
        private static void CollectControls(Control.ControlCollection controls, List<Control> allControls)
        {
            foreach (Control control in controls)
            {
                allControls.Add(control); // 将当前控件添加到列表中
                                          // 如果当前控件有子控件，则递归调用此方法
                if (control.HasChildren)
                {
                    CollectControls(control.Controls, allControls);
                }
            }
        }
        #endregion

    }
}
