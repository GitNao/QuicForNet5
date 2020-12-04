// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

internal static partial class Interop
{
    internal static partial class Libraries
    {
#if WINDOWS
        internal const string MsQuic = "msquic.dll";
#else
        internal const string MsQuic = "libmsquic.so";
#endif
    }
}
