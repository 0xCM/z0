//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;


    public abstract class t_asm<U> : UnitTest<U>
        where U : t_asm<U>
    {
        protected IAsmContext Context;
        
        public t_asm()
        {
            Context = AsmContext.New(ClrMetadataIndex.Empty, DataResourceIndex.Empty, AsmFormatConfig.Default);            
        }

        public void Dispose()
        {

        }

        protected string Math
            => nameof(math);
        
        protected string GMath
            => nameof(gmath);

        protected OpIdentity TestOpName<T>(string basename, T t = default)
            where T : unmanaged
                => Identity.operation($"{basename}_asm",typeof(T).NumericKind());

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        protected IAsmHexWriter HexTestWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  Context.HexWriter(dst);
        }

        protected IAsmFunctionWriter AsmTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);    
            return Context.WithFormat(DefaultAsmFormat).AsmWriter(path);
        }

        /// <summary>
        /// Evaluates a pair of unary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        protected void CheckMatch<T>(in AsmBuffers buffers, string basename, UnaryOp<T> f, UnaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, CaseName(TestOpName<T>(basename)));
        }    

        /// <summary>
        /// Evaluates a pair of binary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        protected void CheckMatch<T>(in AsmBuffers buffers, string opname, BinaryOp<T> f, BinaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName(TestOpName<T>(opname)));
        }

        protected void CheckAsmMatch<T>(in AsmBuffers buffers, UnaryOp<T> f, AsmCode src)
            where T : unmanaged
        {
            //var g = AsmBuffer.UnaryOp(src.Typed<T>());

            var g = buffers.MainExec.Load(src).UnaryOp<T>(src.Id);            

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, src.Id);
        }

        protected void CheckAsmMatch<T>(in AsmBuffers buffers, UnaryOp<T> f, TypedAsm<T> asm)
            where T : unmanaged
                => CheckAsmMatch(buffers, f, asm.Untyped);

        protected void CheckAsmMatch<T>(in AsmBuffers buffers, BinaryOp<T> f, AsmCode src)
            where T : unmanaged
        {
                      
            //var g = AsmBuffer.BinaryOp(asm.Typed<T>());
            var g = buffers.MainExec.BinaryOp<T>(src.Id);

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, src.Id);
        }

        protected void CheckAsmMatch<T>(in AsmBuffers buffers, BinaryOp<T> f, TypedAsm<T> asm)
            where T : unmanaged
                => CheckAsmMatch(buffers, f,asm.Untyped);

        protected AsmCode ReadAsm(string catalog, string subject, OpIdentity m)
            => Context.CodeArchive(catalog,subject).Read(m).Single();

        protected TypedAsm<T> ReadAsm<W,T>(string catalog, string subject, string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            var archive = Context.CodeArchive(catalog,subject);
            var id = Identity.contracted(opname, w, NumericType.kind<T>());
            Trace($"{id}");
            var result = Context.CodeArchive(catalog,subject).Read<T>(id);
            if(!result)
                Claim.failwith($"Could not find {id} in the archive at {archive.Root}");
            return result.Require();
        }

        protected void CheckMatch<T>(in AsmBuffers buffers, BinaryOp<Vector128<T>> f, BinaryOp128 g)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        protected void CheckMatch<T>(in AsmBuffers buffers, BinaryOp<Vector256<T>> f, BinaryOp256 g)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, HK.Numeric<byte> kind)
        {
            var w = n8;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w,ReadAsm(GMath, Math, moniker));

            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, HK.Numeric<sbyte> kind)
        {
            var w = n8;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, in AsmCode dCode, in AsmCode gCode, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, HK.Numeric<sbyte> kind)
        {
            var w = n8;

            var id = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, id, f1, id.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, dCode);
            CheckMatch(f0, id, f2, id.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, gCode);
            CheckMatch(f0, id, f3, id.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, HK.Numeric<ushort> kind)
        {
            var w = n16;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }


        protected void megacheck(in AsmBuffers buffers, string name, Func<short,short,short> primal, Func<short,short,short> generic, HK.Numeric<short> kind)
        {
            var w = n16;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, HK.Numeric<uint> kind)
        {
            var w = n32;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<int,int,int> primal, Func<int,int,int> generic, HK.Numeric<int> kind)
        {
            var w = n32;
            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<long,long,long> primal, Func<long,long,long> generic, HK.Numeric<long> kind)
        {            
            var w = n64;
            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(in AsmBuffers buffers, string name, Func<ulong,ulong,ulong> primal, Func<ulong,ulong,ulong> generic, HK.Numeric<ulong> kind)
        {            
            var w = n64;

            var moniker = Identity.operation(name, kind);                        
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = buffers.MainExec.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }
    }
}
