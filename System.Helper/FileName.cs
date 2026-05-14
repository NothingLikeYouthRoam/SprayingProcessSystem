namespace System.Helper
{
    public static class DelFile
    {


        /// <summary>
        /// 定期删除文件夹
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="saveDay"></param>
        public static void DeleteFolder(string folderPath, int saveDay)
        {
            DateTime nowtime = DateTime.Now; //获取当前时间
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            foreach (DirectoryInfo dir in directoryInfos)
            {
                DeleteFolder(dir.FullName, saveDay);  //递归调用
            }
            TimeSpan t = nowtime - directoryInfo.CreationTime;  //当前时间  减去 文件夹创建时间
            int day = t.Days;
            if (day > saveDay)   //保存的时间 ；  单位：天
            {
                Directory.Delete(folderPath, true);  //删除超过时间的文件夹
            }
        }


    }
}
