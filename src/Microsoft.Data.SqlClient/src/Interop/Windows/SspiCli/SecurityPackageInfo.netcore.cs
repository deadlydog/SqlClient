// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NET && !NET8_0_OR_GREATER

using System.Runtime.InteropServices;

namespace System.Net
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct SecurityPackageInfo
    {
        // see SecPkgInfoW in <sspi.h>
        internal int Capabilities;
        internal short Version;
        internal short RPCID;
        internal int MaxToken;
        internal IntPtr Name;
        internal IntPtr Comment;
    }
}

#endif
