//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static z;

    [ApiDataType]
    public unsafe ref struct ClrSigParser
    {
        public const int IMAGE_CEE_CS_CALLCONV_GENERIC = 0x10;

        public const int IMAGE_CEE_CS_CALLCONV_MASK = 0x0f;

        public const int IMAGE_CEE_CS_CALLCONV_DEFAULT = 0x0;

        public const int IMAGE_CEE_CS_CALLCONV_VARARG = 0x5;

        public const int IMAGE_CEE_CS_CALLCONV_FIELD = 0x6;

        public const int IMAGE_CEE_CS_CALLCONV_LOCAL_SIG = 0x7;

        public const byte ELEMENT_TYPE_CMOD_REQD = 0x1F;

        public const byte ELEMENT_TYPE_CMOD_OPT = 0x20;

        public const byte ELEMENT_TYPE_INTERNAL = 0x21;

        public const byte ELEMENT_TYPE_MAX = 0x22;

        public const byte ELEMENT_TYPE_MODIFIER = 0x40;

        public const byte ELEMENT_TYPE_SENTINEL = 0x01 | ELEMENT_TYPE_MODIFIER;

        public const byte ELEMENT_TYPE_PINNED = 0x05 | ELEMENT_TYPE_MODIFIER;

        public const int mdtModule = 0x00000000;

        public const int mdtTypeRef = 0x01000000;

        public const int mdtTypeDef = 0x02000000;

        public const int mdtFieldDef = 0x04000000;

        public const int mdtMethodDef = 0x06000000;

        public const int mdtParamDef = 0x08000000;

        public const int mdtInterfaceImpl = 0x09000000;

        public const int mdtMemberRef = 0x0a000000;

        public const int mdtCustomAttribute = 0x0c000000;

        public const int mdtPermission = 0x0e000000;

        public const int mdtSignature = 0x11000000;

        public const int mdtEvent = 0x14000000;

        public const int mdtProperty = 0x17000000;

        public const int mdtMethodImpl = 0x19000000;

        public const int mdtModuleRef = 0x1a000000;

        public const int mdtTypeSpec = 0x1b000000;

        public const int mdtAssembly = 0x20000000;

        public const int mdtAssemblyRef = 0x23000000;

        public const int mdtFile = 0x26000000;

        public const int mdtExportedType = 0x27000000;

        public const int mdtManifestResource = 0x28000000;

        public const int mdtGenericParam = 0x2a000000;

        public const int mdtMethodSpec = 0x2b000000;

        public const int mdtGenericParamConstraint = 0x2c000000;

        public const int mdtString = 0x70000000;

        public const int mdtName = 0x71000000;

        public const int mdtBaseType = 0x72000000; // Leave this on the high end value. This does not correspond to metadata table

        byte* _sig;

        int _len;

        int _offs;

        readonly Span<int> Tokens;

        public ClrSigParser(ClrSigParser src)
        {
            Tokens =  array(mdtTypeDef, mdtTypeRef, mdtTypeSpec, mdtBaseType);
            _sig = src._sig;
            _len = src._len;
            _offs = src._offs;
        }

        public ClrSigParser(IntPtr sig, int len)
        {
            Tokens =  array(mdtTypeDef, mdtTypeRef, mdtTypeSpec, mdtBaseType);
            if (len != 0)
            {
                _sig = (byte*)sig.ToPointer();
            }
            else
            {
                _sig = null;
            }

            _len = len;
            _offs = 0;
        }

        public ClrSigParser(MemoryAddress sig, uint len)
        {
            Tokens =  array(mdtTypeDef, mdtTypeRef, mdtTypeSpec, mdtBaseType);
            if (len != 0)
                _sig = sig.Pointer<byte>();
            else
                _sig = null;

            _len = (int)len;
            _offs = 0;
        }

        public bool IsNull()
        {
            return _sig is null;
        }

        public bool PeekElemType(out int etype)
        {
            if (_len > 0)
            {
                byte type = _sig[_offs];
                if (type < (byte)CorElementType.ELEMENT_TYPE_CMOD_REQD)
                {
                    etype = type;
                    return true;
                }
            }

            return PeekElemTypeSlow(out etype);
        }

        public bool GetData(out int data)
        {
            if (UncompressData(out data, out int size))
            {
                SkipBytes(size);
                return true;
            }

            return false;
        }

        public bool GetToken(out int token)
        {
            if (UncompressToken(out token, out int size))
            {
                SkipBytes(size);
                return true;
            }

            return false;
        }

        public bool SkipCustomModifiers()
        {
            ClrSigParser sigTemp = new ClrSigParser(this);

            if (!sigTemp.SkipAnyVASentinel())
                return false;

            if (!sigTemp.PeekByte(out byte bElementType))
                return false;

            while (bElementType == ELEMENT_TYPE_CMOD_REQD || bElementType == ELEMENT_TYPE_CMOD_OPT)
            {
                sigTemp.SkipBytes(1);
                if (!sigTemp.GetToken(out _))
                    return false;

                if (!sigTemp.PeekByte(out bElementType))
                    return false;
            }

            // Following custom modifiers must be an element type value which is less than ELEMENT_TYPE_MAX, or one of the other element types
            // that we support while parsing various signatures
            if (bElementType >= ELEMENT_TYPE_MAX)
            {
                switch (bElementType)
                {
                    case ELEMENT_TYPE_PINNED:
                        break;
                    default:
                        return false;
                }
            }

            CopyFrom(sigTemp);
            return true;
        }

        public static bool primitive(ClrTypeCode src)
        {
            return src >= ClrTypeCode.Bool8 && src <= ClrTypeCode.Float64
                || src == ClrTypeCode.IntI || src == ClrTypeCode.IntU
                || src == ClrTypeCode.Ptr || src == ClrTypeCode.PtrFx;
        }


        public bool SkipExactlyOne()
        {
            if (!GetElemType(out int typ))
                return false;

            if (!primitive(((ClrTypeCode)typ)))
            {
                switch ((CorElementType)typ)
                {
                    default:
                        return false;

                    case CorElementType.ELEMENT_TYPE_VAR:
                    case CorElementType.ELEMENT_TYPE_MVAR:
                        if (!GetData(out _))
                            return false;

                        break;

                    case CorElementType.ELEMENT_TYPE_OBJECT:
                    case CorElementType.ELEMENT_TYPE_STRING:
                    case CorElementType.ELEMENT_TYPE_TYPEDBYREF:
                        break;

                    case CorElementType.ELEMENT_TYPE_BYREF:
                    case CorElementType.ELEMENT_TYPE_PTR:
                    case CorElementType.ELEMENT_TYPE_PINNED:
                    case CorElementType.ELEMENT_TYPE_SZARRAY:
                        if (!SkipExactlyOne())
                            return false;

                        break;

                    case CorElementType.ELEMENT_TYPE_VALUETYPE:
                    case CorElementType.ELEMENT_TYPE_CLASS:
                        if (!GetToken(out _))
                            return false;

                        break;

                    case CorElementType.ELEMENT_TYPE_FNPTR:
                        if (!SkipSignature())
                            return false;

                        break;

                    case CorElementType.ELEMENT_TYPE_ARRAY:
                        // Skip element type
                        if (!SkipExactlyOne())
                            return false;

                        // Get rank;
                        int rank;
                        if (!GetData(out rank))
                            return false;

                        if (rank > 0)
                        {
                            if (!GetData(out int sizes))
                                return false;

                            while (sizes-- != 0)
                                if (!GetData(out _))
                                    return false;

                            if (!GetData(out int bounds))
                                return false;

                            while (bounds-- != 0)
                                if (!GetData(out _))
                                    return false;
                        }

                        break;

                    case CorElementType.ELEMENT_TYPE_SENTINEL:
                        // Should be unreachable since GetElem strips it
                        break;

                    case CorElementType.ELEMENT_TYPE_INTERNAL:
                        if (!GetData(out _))
                            return false;

                        break;

                    case CorElementType.ELEMENT_TYPE_GENERICINST:
                        // Skip generic type
                        if (!SkipExactlyOne())
                            return false;

                        // Get number of parameters
                        int argCnt;
                        if (!GetData(out argCnt))
                            return false;

                        // Skip the parameters
                        while (argCnt-- != 0)
                            SkipExactlyOne();
                        break;
                }
            }

            return true;
        }

        [MethodImpl(Inline)]
        bool GetByte(out byte data)
        {
            if (_len <= 0)
            {
                data = 0xcc;
                return false;
            }

            data = _sig[_offs];
            SkipBytes(1);
            return true;
        }

        [MethodImpl(Inline)]
        bool PeekByte(out byte data)
        {
            if (_len <= 0)
            {
                data = 0xcc;
                return false;
            }

            data = _sig[_offs];
            return true;
        }

        bool GetElemTypeSlow(out int type)
        {
            ClrSigParser sigTemp = new ClrSigParser(this);
            if (sigTemp.SkipCustomModifiers())
            {
                if (sigTemp.GetByte(out byte elemType))
                {
                    type = elemType;
                    CopyFrom(sigTemp);
                    return true;
                }
            }

            type = 0;
            return false;
        }

        public bool GetElemType(out int etype)
        {
            if (_len > 0)
            {
                byte type = _sig[_offs];

                if (type < (byte)CorElementType.ELEMENT_TYPE_CMOD_REQD) // fast path with no modifiers: single byte
                {
                    etype = type;
                    SkipBytes(1);
                    return true;
                }
            }

            // Slower/normal path
            return GetElemTypeSlow(out etype);
        }

        public bool PeekCallingConvInfo(out int data)
        {
            return PeekByte(out data);
        }

        // Note: Calling convention is always one byte, not four bytes
        public bool GetCallingConvInfo(out int data)
        {
            if (PeekByte(out data))
            {
                SkipBytes(1);
                return true;
            }

            return false;
        }

        bool GetCallingConv(out int data)
        {
            if (GetCallingConvInfo(out data))
            {
                data &= IMAGE_CEE_CS_CALLCONV_MASK;
                return true;
            }

            return false;
        }

        bool PeekData(out int data)
        {
            return UncompressData(out data, out _);
        }

        bool PeekElemTypeSlow(out int etype)
        {
            ClrSigParser sigTemp = new ClrSigParser(this);
            return sigTemp.GetElemType(out etype);
        }

        public bool PeekElemTypeSize(out byte pSize)
        {
            pSize = 0;
            ClrSigParser sigTemp = new ClrSigParser(this);

            if (!sigTemp.SkipAnyVASentinel())
                return false;

            if (!sigTemp.GetByte(out byte bElementType))
                return false;

            switch ((CorElementType)bElementType)
            {
                case CorElementType.ELEMENT_TYPE_I8:
                case CorElementType.ELEMENT_TYPE_U8:
                case CorElementType.ELEMENT_TYPE_R8:
                    pSize = 8;
                    break;

                case CorElementType.ELEMENT_TYPE_I4:
                case CorElementType.ELEMENT_TYPE_U4:
                case CorElementType.ELEMENT_TYPE_R4:
                    pSize = 4;
                    break;

                case CorElementType.ELEMENT_TYPE_I2:
                case CorElementType.ELEMENT_TYPE_U2:
                case CorElementType.ELEMENT_TYPE_CHAR:
                    pSize = 2;
                    break;

                case CorElementType.ELEMENT_TYPE_I1:
                case CorElementType.ELEMENT_TYPE_U1:
                case CorElementType.ELEMENT_TYPE_BOOLEAN:
                    pSize = 1;
                    break;

                case CorElementType.ELEMENT_TYPE_I:
                case CorElementType.ELEMENT_TYPE_U:
                case CorElementType.ELEMENT_TYPE_STRING:
                case CorElementType.ELEMENT_TYPE_PTR:
                case CorElementType.ELEMENT_TYPE_BYREF:
                case CorElementType.ELEMENT_TYPE_CLASS:
                case CorElementType.ELEMENT_TYPE_OBJECT:
                case CorElementType.ELEMENT_TYPE_FNPTR:
                case CorElementType.ELEMENT_TYPE_TYPEDBYREF:
                case CorElementType.ELEMENT_TYPE_ARRAY:
                case CorElementType.ELEMENT_TYPE_SZARRAY:
                    pSize = (byte)IntPtr.Size;
                    break;

                case CorElementType.ELEMENT_TYPE_VOID:
                    break;

                case CorElementType.ELEMENT_TYPE_CMOD_REQD:
                case CorElementType.ELEMENT_TYPE_CMOD_OPT:
                case CorElementType.ELEMENT_TYPE_VALUETYPE:
                    Debug.Fail("Asked for the size of an element that doesn't have a size!");
                    return false;

                default:
                    Debug.Fail("CorSigGetElementTypeSize given invalid signature to size!");
                    return false;
            }

            return true;
        }

        bool AtSentinel()
        {
            if (_len > 0)
                return _sig[_offs] == (byte)CorElementType.ELEMENT_TYPE_SENTINEL;

            return false;
        }

        bool SkipFunkyAndCustomModifiers()
        {
            ClrSigParser sigTemp = new ClrSigParser(this);
            if (!sigTemp.SkipAnyVASentinel())
                return false;

            if (!sigTemp.PeekByte(out byte bElementType))
                return false;

            while (bElementType == ELEMENT_TYPE_CMOD_REQD ||
                bElementType == ELEMENT_TYPE_CMOD_OPT ||
                bElementType == ELEMENT_TYPE_MODIFIER ||
                bElementType == ELEMENT_TYPE_PINNED)
            {
                sigTemp.SkipBytes(1);

                if (!sigTemp.GetToken(out int _))
                    return false;

                if (!sigTemp.PeekByte(out bElementType))
                    return false;
            }

            // Following custom modifiers must be an element type value which is less than ELEMENT_TYPE_MAX, or one of the other element types
            // that we support while parsing various signatures
            if (bElementType >= ELEMENT_TYPE_MAX)
            {
                switch (bElementType)
                {
                    case ELEMENT_TYPE_PINNED:
                        break;
                    default:
                        return false;
                }
            }

            CopyFrom(sigTemp);
            return true;
        }

        bool SkipAnyVASentinel()
        {
            if (!PeekByte(out byte bElementType))
                return false;

            if (bElementType == ELEMENT_TYPE_SENTINEL)
                SkipBytes(1);

            return true;
        }

        bool SkipMethodHeaderSignature(out int pcArgs)
        {
            pcArgs = 0;

            // Skip calling convention
            if (!GetCallingConvInfo(out int uCallConv))
                return false;

            if (uCallConv == IMAGE_CEE_CS_CALLCONV_FIELD || uCallConv == IMAGE_CEE_CS_CALLCONV_LOCAL_SIG)
                return false;

            // Skip type parameter count
            if ((uCallConv & IMAGE_CEE_CS_CALLCONV_GENERIC) == IMAGE_CEE_CS_CALLCONV_GENERIC)
                if (!GetData(out _))
                    return false;

            // Get arg count;
            if (!GetData(out pcArgs))
                return false;

            // Skip return type;
            if (!SkipExactlyOne())
                return false;

            return true;
        }

        private bool SkipSignature()
        {
            if (!SkipMethodHeaderSignature(out int args))
                return false;

            // Skip args.
            while (args-- > 0)
                if (!SkipExactlyOne())
                    return false;

            return false;
        }

        bool UncompressToken(out int token, out int size)
        {
            if (!UncompressData(out token, out size))
                return false;

            int tkType = Tokens[token & 3];
            token = (token >> 2) | tkType;
            return true;
        }

        byte GetSig(int offs)
        {
            return _sig[_offs + offs];
        }

        bool UncompressData(out int pDataOut, out int pDataLen)
        {
            pDataOut = 0;
            pDataLen = 0;

            if (_len <= 0)
                return false;

            byte byte0 = GetSig(0);

            // Smallest.
            if ((byte0 & 0x80) == 0x00) // 0??? ????
            {
                if (_len < 1)
                {
                    return false;
                }

                pDataOut = byte0;
                pDataLen = 1;
            }

            // Medium.
            else if ((byte0 & 0xC0) == 0x80) // 10?? ????
            {
                if (_len < 2)
                {
                    return false;
                }

                pDataOut = ((byte0 & 0x3f) << 8) | GetSig(1);
                pDataLen = 2;
            }
            else if ((byte0 & 0xE0) == 0xC0) // 110? ????
            {
                if (_len < 4)
                {
                    return false;
                }

                pDataOut = ((byte0 & 0x1f) << 24) | (GetSig(1) << 16) | (GetSig(2) << 8) | GetSig(3);
                pDataLen = 4;
            }
            else // We don't recognize this encoding
            {
                return false;
            }

            return true;
        }

        bool PeekByte(out int data)
        {
            if (!PeekByte(out byte tmp))
            {
                data = 0xcc;
                return false;
            }

            data = tmp;
            return true;
        }

        void CopyFrom(ClrSigParser rhs)
        {
            _sig = rhs._sig;
            _len = rhs._len;
            _offs = rhs._offs;
        }

        void SkipBytes(int bytes)
        {
            _offs += bytes;
            _len -= bytes;
        }

        bool SkipInt()
        {
            return GetData(out int _);
        }
    }
}