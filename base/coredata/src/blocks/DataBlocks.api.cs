//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Reflection;
        
    using static zfunc;

    public interface IDataBlockMeta
    {
        IEnumerable<Type> BlockTypes {get;}

        IEnumerable<Type> InBlockTypes {get;}

        bool IsBlockType(Type t);
    }

    class DataBlockMetadata : IDataBlockMeta
    {
        public static readonly IDataBlockMeta TheOnly = new DataBlockMetadata();
        
        HashSet<Type> MutableIn;

        HashSet<Type> MutableRef;

        HashSet<Type> MutableDirect;

        HashSet<Type> ConstDirect;

        HashSet<Type> All;

        public IEnumerable<Type> BlockTypes 
            => All;

        public IEnumerable<Type> InBlockTypes 
            => MutableIn;

        DataBlockMetadata()
        {
            MutableIn = new HashSet<Type>(GetType().GetMethod(nameof(mutable_in_block_types), BindingFlags.Static | BindingFlags.NonPublic).GetParameters().Select(p => p.ParameterType));
            MutableRef = new HashSet<Type>(GetType().GetMethod(nameof(mutable_ref_block_types), BindingFlags.Static | BindingFlags.NonPublic).GetParameters().Select(p => p.ParameterType));
            MutableDirect = new HashSet<Type>(items(typeof(Block16<>), typeof(Block32<>), typeof(Block64<>), typeof(Block128<>), typeof(Block256<>), typeof(Block512<>)));
            ConstDirect = new HashSet<Type>(items(typeof(ConstBlock16<>), typeof(ConstBlock32<>), typeof(ConstBlock64<>), typeof(ConstBlock128<>), typeof(ConstBlock256<>), typeof(ConstBlock512<>)));
            All = new HashSet<Type>(MutableIn.Union(MutableRef).Union(MutableDirect).Union(ConstDirect));
            Names = items(
                "Block16", "Block32", "Block64", "Block128", "Block256", "Block512",
                "ConstBlock16", "ConstBlock32", "ConstBlock64", "ConstBlock128", "ConstBlock256", "ConstBlock512"
                ).ToHashSet();
            
        }
        HashSet<string> Names {get;}
        static void mutable_in_block_types<T>(in Block16<T> a, in Block32<T> b, in Block64<T> c, in Block128<T> d, in Block256<T> e, in Block512<T> f)
            where T : unmanaged
        {

        }

        static void mutable_ref_block_types<T>(ref Block16<T> a, ref Block32<T> b, ref Block64<T> c, ref Block128<T> d, ref Block256<T> e, ref Block512<T> f)
            where T : unmanaged
        {

        }

        [MethodImpl(Inline)]
        static IEnumerable<T> items<T>(params T[] src)
            => src;

        public bool IsBlockType(Type t)
            => Names.Where(n => t.Name.StartsWith(n)).Any();

    }

    /// <summary>
    /// Defines api surface for blocked span allocation/manipulation
    /// </summary>
    public static partial class DataBlocks
    {
        public static IEnumerable<Type> BlockTypes
            => DataBlockMetadata.TheOnly.BlockTypes;

        public static IEnumerable<Type> InBlockTypes
            => DataBlockMetadata.TheOnly.InBlockTypes;

        /// <summary>
        /// Determines whether a type is a data block of some sort
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool isblocked(Type t)
            => DataBlockMetadata.TheOnly.IsBlockType(t);

        [MethodImpl(Inline)]
        static IEnumerable<T> items<T>(params T[] src)
            => src;
    }
}