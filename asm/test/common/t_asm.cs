//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using static Classifiers;

    using static zfunc;
    public abstract class t_asm<U> : UnitTest<U>, IDisposable
        where U : t_asm<U>
    {
        protected INativeExecBuffer AsmBuffer;

        INativeExecBuffer[] AsmBuffers;

        public t_asm()
        {
            AsmBuffer = NativeServices.ExecBuffer();
            AsmBuffers = new INativeExecBuffer[]{
                NativeServices.ExecBuffer(),
                NativeServices.ExecBuffer()
            };
        }
        public void Dispose()
        {
            AsmBuffer.Dispose();
            AsmBuffers[0].Dispose();
            AsmBuffers[1].Dispose();
        }

        protected INativeExecBuffer LeftBuffer
            => AsmBuffers[0];

        protected INativeExecBuffer RightBuffer
            => AsmBuffers[1];

        protected string Math
            => nameof(math);
        
        protected string GMath
            => nameof(gmath);

        protected IAsmWriter AsmTestWriter(AsmFormatConfig format, [Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, Paths.AsmExt);    
            return AsmServices.Writer(path,format);
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
                      
            var g = AsmBuffer.BinaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, asm.Id);
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

            CheckAction(check, asm.Id);
        }

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f, asm.Untyped);

        protected AsmCode ReadAsm(string catalog, string subject, Moniker m)
            => AsmServices.CodeArchive(catalog,subject).ReadBlock(m).Require();

        protected AsmCode ReadAsm(string catalog, string subject, string opname, PrimalKind kind)
            => AsmServices.CodeArchive(catalog,subject).ReadBlock(OpIdentity.define(opname,kind)).Require();

        protected AsmCode<T> ReadAsm<T>(string catalog, string subject, string opname, T t = default)
            where T : unmanaged
                => new AsmCode<T>(ReadAsm(catalog, subject, opname, typeof(T).Kind()));

        protected AsmCode<T> ReadAsm<W,T>(string catalog, string subject, string opname, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => AsmServices.CodeArchive(catalog,subject).ReadBlock<T>(OpIdentity.segmented(opname, PrimalType.kind<T>(), w)).Require(); 

        protected void megacheck(string name, Func<byte,byte,byte> primal, Func<byte,byte,byte> generic, PrimalClass<byte> kind)
        {
            var w = n8;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<sbyte,sbyte,sbyte> primal, Func<sbyte,sbyte,sbyte> generic, PrimalClass<sbyte> kind)
        {
            var w = n8;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<ushort,ushort,ushort> primal, Func<ushort,ushort,ushort> generic, PrimalClass<ushort> kind)
        {
            var w = n16;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<short,short,short> primal, Func<short,short,short> generic, PrimalClass<short> kind)
        {
            var w = n16;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<uint,uint,uint> primal, Func<uint,uint,uint> generic, PrimalClass<uint> kind)
        {
            var w = n32;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<int,int,int> primal, Func<int,int,int> generic, PrimalClass<int> kind)
        {
            var w = n32;
            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math ,moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<long,long,long> primal, Func<long,long,long> generic, PrimalClass<long> kind)
        {            
            var w = n64;
            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math ,moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }

        protected void megacheck(string name, Func<ulong,ulong,ulong> primal, Func<ulong,ulong,ulong> generic, PrimalClass<ulong> kind)
        {            
            var w = n64;

            var moniker = OpIdentity.define(name, kind);                        
            var f0 = Fixed.BinOp(primal, kind);

            var f1 = Fixed.BinOp(generic, kind);
            CheckMatch(f0, moniker, f1, moniker.WithGeneric());

            var f2 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, Math, moniker));
            CheckMatch(f0, moniker, f2, moniker.WithAsm());

            var f3 = AsmBuffer.BinaryOp(w, ReadAsm(GMath, GMath, moniker.WithGeneric()));
            CheckMatch(f0, moniker, f3, moniker.WithGeneric().WithAsm());
        }
    }
}
