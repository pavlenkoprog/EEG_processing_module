using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MainModuleEEGprocessing
{
    class IniFile
    {
        string Path;

        [DllImport( "kernel32" )] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
        static extern long WritePrivateProfileString( string Section , string Key , string Value , string FilePath );

        [DllImport( "kernel32" )] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
        static extern int GetPrivateProfileString( string Section , string Key , string Default , StringBuilder RetVal , int Size , string FilePath );

        // С помощью конструктора записываем пусть до файла и его имя.
        public IniFile( string IniPath )
        {
            Path = new FileInfo( IniPath ).FullName.ToString( );
        }


    }
}
