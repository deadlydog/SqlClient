// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NET

using System;
using System.Runtime.InteropServices;
using Interop_TEMP.Windows.Handles;

internal partial class Interop
{
    internal partial class Kernel32
    {
        public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;
        public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

        [DllImport(Libraries.Kernel32, ExactSpelling = true, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern SafeLibraryHandle LoadLibraryExW([In] string lpwLibFileName, [In] IntPtr hFile, [In] uint dwFlags);
    }
}

#endif
