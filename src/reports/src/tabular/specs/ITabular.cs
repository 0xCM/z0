//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    public interface ITabular
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter) => string.Empty;

        string[] HeaderNames {get;}        
    }

    public interface IRecord : ITabular, ISequential
    {

    }

    public interface ITabular<R> : ITabular
        where R : ITabular
    {
        string[] ITabular.HeaderNames
            => TabularFormats.headers<R>();
    }

    public interface IRecord<R> : IRecord, ITabular<R>
        where R : IRecord
    {


    }


    public interface ITabular<F,T> : ITabular<T>
        where F : unmanaged, Enum
        where T : ITabular
    {
        static void Save(T[] src, FilePath dst, char delimiter = Chars.Pipe)
        {
            var formatted = new string[src.Length];            
            for(var i=0; i<src.Length; i++)
                formatted[i] = src[i].DelimitedText(delimiter);

            using var writer = dst.Writer();
            writer.WriteLine(Tabular.header<F>(delimiter)); 
            writer.WriteLine(new string(Chars.Dash, formatted.Max(x => x.Length)));
            for(var i=0; i< formatted.Length; i++)
                writer.WriteLine(formatted[i]);            
        }            
    }   

    public interface IRecord<F,R> : IRecord<R>, ITabular<F,R>
        where F : unmanaged, Enum
        where R : IRecord
    {

        
    }

    public interface ITabularArchive<F,T> : ILocalArchive
        where F : unmanaged, Enum
        where T : ITabular
    {
        FilePath Deposit(T[] src, FileName filename)        
        {
            var dst = ArchiveRoot + filename;
            ITabular<F,T>.Save(src, dst);
            return dst;
        }           

        FilePath Deposit(T[] src,  FolderName folder, FileName filename)       
        {
            var dst = (ArchiveRoot + folder) + filename;
            ITabular<F,T>.Save(src, dst);
            return dst;
        }    
    }

    public class TabularArchive
    {
        public static void Save<F,R>(R[] src, FilePath dst, Func<R,string> formatter, char delimiter = Chars.Pipe)
            where F : unmanaged, Enum
            where R : ITabular
        {
            var formatted = new string[src.Length];            
            for(var i=0; i<src.Length; i++)
                formatted[i] = formatter(src[i]);

            using var writer = dst.Writer();            
            writer.WriteLine(Tabular.header<F>(delimiter)); 
            
            for(var i=0; i< formatted.Length; i++)
                writer.WriteLine(formatted[i]);            
        }            

        public static void Save<F,R>(R[] src, FilePath dst, char sep = Chars.Pipe)  
            where F : unmanaged, Enum
            where R : ITabular
                => ITabular<F,R>.Save(src,dst,sep);

        /// <summary>
        /// Creates a tabular archive rooted at a specified path
        /// </summary>
        /// <param name="root">The archive root</param>
        /// <typeparam name="F">The field type</typeparam>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static TabularArchive<F,T> Create<F,T>(FolderPath root)
            where F : unmanaged, Enum
            where T : ITabular
                => new TabularArchive<F,T>(root);
    }

    public readonly struct TabularArchive<F,T> : ITabularArchive<F,T>
        where F : unmanaged, Enum
        where T : ITabular
    {
        [MethodImpl(Inline)]
        internal TabularArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public FolderPath ArchiveRoot {get;}
    }
}