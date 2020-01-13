using System;
using System.Runtime.InteropServices;


namespace GayMaker
{
    class GMAC
    {
        public enum FileMapProtection : uint
        {
            PageReadonly = 0x02,
            PageReadWrite = 0x04,
            PageWriteCopy = 0x08,
            PageExecuteRead = 0x20,
            PageExecuteReadWrite = 0x40,
            SectionCommit = 0x8000000,
            SectionImage = 0x1000000,
            SectionNoCache = 0x10000000,
            SectionReserve = 0x4000000,
        }

        public enum FileMapAccess : uint
        {
            FileMapCopy = 0x0001,
            FileMapWrite = 0x0002,
            FileMapRead = 0x0004,
            FileMapReadWrite = 0x0006,
            FileMapAllAccess = 0x001f,
            FileMapExecute = 0x0020,
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFileMapping(
            IntPtr hFile,
            IntPtr lpFileMappingAttributes,
            FileMapProtection flProtect,
            uint dwMaximumSizeHigh,
            uint dwMaximumSizeLow,
            string lpName
        );

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr MapViewOfFile(IntPtr intptr_0, FileMapAccess dwDesiredAccess, int int_5, int int_6, IntPtr intptr_1);

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenFileMapping(
            FileMapAccess dwDesiredAccess,
            bool bInheritHandle,
            string lpName
        );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr intptr_0);

        public static void GetPermissionToExecute()
        {
            IntPtr Create = CreateFileMapping(new IntPtr(-1), IntPtr.Zero, FileMapProtection.PageReadWrite, 0x0, 0x1000, "YYMappingFileTestYY");
            IntPtr DaFile = OpenFileMapping(FileMapAccess.FileMapWrite, false, "YYMappingFileTestYY");
            IntPtr MapView = MapViewOfFile(DaFile, FileMapAccess.FileMapWrite, 0, 0, new IntPtr(4));

            Marshal.WriteInt32(MapView, (int)(DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);

            CloseHandle(DaFile);
        }
    }
}
