/********************************************************
 * ADO.NET 2.0 Data Provider for SQLite Version 3.X
 * Written by Robert Simpson (robert@blackcastlesoft.com)
 *
 * Released to the public domain, use at your own risk!
 ********************************************************/

using System.Collections.Generic;

namespace System.Data.DenverDB
{
    internal static class SQLiteDefineConstants
    {
        public static readonly IList<string> OptionList = new List<string>(new string[] {
#if CHECK_STATE
            "CHECK_STATE",
#endif

#if COUNT_HANDLE
            "COUNT_HANDLE",
#endif

#if DEBUG
            "DEBUG",
#endif

#if INTEROP_CODEC
            "INTEROP_CODEC",
#endif

#if INTEROP_DEBUG
            "INTEROP_DEBUG",
#endif

#if INTEROP_EXTENSION_FUNCTIONS
            "INTEROP_EXTENSION_FUNCTIONS",
#endif

#if INTEROP_LEGACY_CLOSE
            "INTEROP_LEGACY_CLOSE",
#endif

#if INTEROP_LOG
            "INTEROP_LOG",
#endif

#if INTEROP_TEST_EXTENSION
            "INTEROP_TEST_EXTENSION",
#endif

#if INTEROP_VIRTUAL_TABLE
            "INTEROP_VIRTUAL_TABLE",
#endif

#if NET_20
            "NET_20",
#endif

#if NET_35
            "NET_35",
#endif

#if NET_40
            "NET_40",
#endif

#if NET_45
            "NET_45",
#endif

#if NET_451
            "NET_451",
#endif

#if NET_COMPACT_20
            "NET_COMPACT_20",
#endif

#if PLATFORM_COMPACTFRAMEWORK
            "PLATFORM_COMPACTFRAMEWORK",
#endif

#if PRELOAD_NATIVE_LIBRARY
            "PRELOAD_NATIVE_LIBRARY",
#endif

#if RETARGETABLE
            "RETARGETABLE",
#endif

#if SQLITE_STANDARD
            "SQLITE_STANDARD",
#endif

#if THROW_ON_DISPOSED
            "THROW_ON_DISPOSED",
#endif

#if TRACE
            "TRACE",
#endif

#if TRACE_CONNECTION
            "TRACE_CONNECTION",
#endif

#if TRACE_DETECTION
            "TRACE_DETECTION",
#endif

#if TRACE_HANDLE
            "TRACE_HANDLE",
#endif

#if TRACE_PRELOAD
            "TRACE_PRELOAD",
#endif

#if TRACE_SHARED
            "TRACE_SHARED",
#endif

#if TRACE_STATEMENT
            "TRACE_STATEMENT",
#endif

#if TRACE_WARNING
            "TRACE_WARNING",
#endif

#if TRACK_MEMORY_BYTES
            "TRACK_MEMORY_BYTES",
#endif

#if USE_ENTITY_FRAMEWORK_6
            "USE_ENTITY_FRAMEWORK_6",
#endif

#if USE_INTEROP_DLL
            "USE_INTEROP_DLL",
#endif

#if USE_PREPARE_V2
            "USE_PREPARE_V2",
#endif

#if WINDOWS
            "WINDOWS",
#endif

            null
        });
    }
}
