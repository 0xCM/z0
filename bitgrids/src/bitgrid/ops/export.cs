//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;

    using static Core;

    partial class BitGrid
    {                
        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(BitGrid16<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(BitGrid32<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(BitGrid64<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(BitGrid128<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N,T>(g.data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(BitGrid256<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N,T>(g.data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(SubGrid16<M,N,T> g, FilePath dst,  bool showrow = false,  [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(SubGrid32<M,N,T> g, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(SubGrid64<M,N,T> g, FilePath dst, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N>(g.Data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(SubGrid128<M,N,T> g, FilePath dst, bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N,T>(g.data, showrow, label);

        /// <summary>
        /// Exports a grid to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static string export<M,N,T>(SubGrid256<M,N,T> g,  bool showrow = false, [CallerMemberName] string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
                => export<M,N,T>(g.data, showrow, label);

        static FileName filename<W,M,N,T>(string label, W w, M m = default, N n = default, T t = default)
            where W: unmanaged, ITypeNat
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged        
                => FileName.Define($"{label}_{sigtext(w,m,n,t)}","grid");            

        /// <summary>
        /// Creates a grid writer predicated on type parameters
        /// </summary>
        /// <param name="label">The grid label</param>
        /// <param name="w">The grid width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cel type representative</param>
        /// <typeparam name="W">The grid width type</typeparam>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static StreamWriter writer<W,M,N,T>([CallerMemberName] string label = null, W w = default, M m = default, N n = default, T t = default)
            where W: unmanaged, ITypeNat
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged        
                => ((Env.Current.LogDir + FolderName.Define("grids")) +  filename(label,w,m,n,t) ).Writer();

        /// <summary>
        /// Exports grid data to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static string export<M,N>(ushort g, bool showrow = false, string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
        {
            var data = render<M,N>(g,showrow,label);
            using var sink = writer(label,n16, default(M), default(N), default(ushort));
            sink.WriteLine(data);
            sink.Flush();
            return data;
        }

        /// <summary>
        /// Exports grid data to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static string export<M,N>(uint g, bool showrow = false, string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
        {
            var data = render<M,N>(g,showrow,label);
            using var sink = writer(label,n32, default(M), default(N), default(uint));
            sink.WriteLine(data);
            sink.Flush();
            return data;
        }

        /// <summary>
        /// Exports grid data to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static string export<M,N>(ulong g, bool showrow = false, string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
        {
            var data = render<M,N>(g,showrow,label);
            using var sink = writer(label,n64, default(M), default(N), default(ulong));
            sink.WriteLine(data);
            sink.Flush();
            return data;
        }

        /// <summary>
        /// Exports grid data to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static string export<M,N,T>(Vector128<T> g, bool showrow = false, string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
        {
            var data = render<M,N,T>(g,showrow,label);
            using var sink = writer(label,n128, default(M), default(N), default(T));
            sink.WriteLine(data);
            sink.Flush();
            return data;
        }

        /// <summary>
        /// Exports grid data to a file
        /// </summary>
        /// <param name="g">The grid to render</param>
        /// <param name="showrow">Whether grid row indicies should be displayed</param>
        /// <param name="label">The grid label</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static string export<M,N,T>(Vector256<T> g, bool showrow = false, string label = null)
            where M: unmanaged, ITypeNat
            where N: unmanaged, ITypeNat
            where T: unmanaged
        {
            var data = render<M,N,T>(g,showrow,label);
            using var sink = writer(label,n256, default(M), default(N), default(T));
            sink.WriteLine(data);
            sink.Flush();
            return data;
        }

         static string HeaderSep
            => new string('-',80);     
    }
}