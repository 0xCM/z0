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
    using System.Runtime.Intrinsics;
    using System.IO;

    using static Classifiers;

    using static zfunc;
    public abstract class t_asm<U> : UnitTest<U>, IDisposable
        where U : t_asm<U>
    {

        protected AsmExecBuffer AsmBuffer;

        public t_asm()
        {
            AsmBuffer = AsmExecBuffer.Create();
        }

        public void Dispose()
        {
            AsmBuffer.Dispose();
        }

        protected FolderName MathFolder
            => FolderName.Define(nameof(math));
        
        protected FolderName GMathFolder
            => FolderName.Define(nameof(gmath));

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
                      
            var g = AsmBuffer.BinOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, asm.Name);
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f,asm.Untyped);

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            var g = AsmBuffer.UnaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, asm.Name);
        }

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f, asm.Untyped);

        protected AsmCode ReadAsm(FolderName subject, Moniker m)
            => AsmLib.Read(subject, m);

        protected AsmCode ReadAsm(FolderName subject, string opname, PrimalKind kind)
            => AsmLib.Read(subject, Moniker.define(opname,kind));

        protected AsmCode<T> ReadAsm<T>(FolderName subject, string opname, T t = default)
            where T : unmanaged
                => new AsmCode<T>(ReadAsm(subject, opname, typeof(T).Kind()));

        protected AsmCode<T> ReadAsm<W,T>(string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => AsmLib.Intrinsic<T>(Moniker.define(opname, PrimalType.kind<T>(), w));


        protected void megacheck(string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, PrimalKind<byte> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp8(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp8(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, PrimalKind<sbyte> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp8(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp8(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, PrimalKind<ushort> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp16(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp16(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<short,short,short> primal, Func<short,short,short> generic, PrimalKind<short> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp16(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp16(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, PrimalKind<uint> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp32(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp32(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<int,int,int> primal, Func<int,int,int> generic, PrimalKind<int> kind)
        {
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp32(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp32(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<long,long,long> primal, Func<long,long,long> generic, PrimalKind<long> kind)
        {            
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp64(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp64(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }


        protected void megacheck(string name, Func<ulong,ulong,ulong> primal, Func<ulong,ulong,ulong> generic, PrimalKind<ulong> kind)
        {            
            var moniker = Moniker.define(name, kind);                        
            var f0 = FixedDelegate.from(primal, kind);

            var f1 = FixedDelegate.from(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinOp64(ReadAsm(MathFolder, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinOp64(ReadAsm(GMathFolder, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

    }
}
