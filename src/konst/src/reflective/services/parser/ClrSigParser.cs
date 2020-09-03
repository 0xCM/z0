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
    using System.Diagnostics;

    using static ImageLiterals;

    [ApiDataType]
    public unsafe ref struct ClrSigParser
    {
        byte* _sig;

        int _len;

        int _offs;

        readonly Span<int> s_tkCorEncodeToken;

        public ClrSigParser(ClrSigParser rhs)
        {
            s_tkCorEncodeToken =  z.array(mdtTypeDef, mdtTypeRef, mdtTypeSpec, mdtBaseType);
            _sig = rhs._sig;
            _len = rhs._len;
            _offs = rhs._offs;
        }

        public ClrSigParser(IntPtr sig, int len)
        {
            s_tkCorEncodeToken =  z.array(mdtTypeDef, mdtTypeRef, mdtTypeSpec, mdtBaseType);
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

        public bool IsNull()
        {
            return _sig is null;
        }

        private void CopyFrom(ClrSigParser rhs)
        {
            _sig = rhs._sig;
            _len = rhs._len;
            _offs = rhs._offs;
        }

        private void SkipBytes(int bytes)
        {
            _offs += bytes;
            _len -= bytes;
        }

        private bool SkipInt()
        {
            return GetData(out int _);
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

        private bool GetByte(out byte data)
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

        private bool PeekByte(out byte data)
        {
            if (_len <= 0)
            {
                data = 0xcc;
                return false;
            }

            data = _sig[_offs];
            return true;
        }

        private bool GetElemTypeSlow(out int type)
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

                if (type < ELEMENT_TYPE_CMOD_REQD) // fast path with no modifiers: single byte
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

        private bool GetCallingConv(out int data)
        {
            if (GetCallingConvInfo(out data))
            {
                data &= IMAGE_CEE_CS_CALLCONV_MASK;
                return true;
            }

            return false;
        }

        private bool PeekData(out int data)
        {
            return UncompressData(out data, out _);
        }

        private bool PeekElemTypeSlow(out int etype)
        {
            ClrSigParser sigTemp = new ClrSigParser(this);
            return sigTemp.GetElemType(out etype);
        }

        public bool PeekElemType(out int etype)
        {
            if (_len > 0)
            {
                byte type = _sig[_offs];
                if (type < ELEMENT_TYPE_CMOD_REQD)
                {
                    etype = type;
                    return true;
                }
            }

            return PeekElemTypeSlow(out etype);
        }

        private bool PeekElemTypeSize(out int pSize)
        {
            pSize = 0;
            ClrSigParser sigTemp = new ClrSigParser(this);

            if (!sigTemp.SkipAnyVASentinel())
                return false;

            if (!sigTemp.GetByte(out byte bElementType))
                return false;

            switch (bElementType)
            {
                case ELEMENT_TYPE_I8:
                case ELEMENT_TYPE_U8:
                case ELEMENT_TYPE_R8:
                    pSize = 8;
                    break;

                case ELEMENT_TYPE_I4:
                case ELEMENT_TYPE_U4:
                case ELEMENT_TYPE_R4:
                    pSize = 4;
                    break;

                case ELEMENT_TYPE_I2:
                case ELEMENT_TYPE_U2:
                case ELEMENT_TYPE_CHAR:
                    pSize = 2;
                    break;

                case ELEMENT_TYPE_I1:
                case ELEMENT_TYPE_U1:
                case ELEMENT_TYPE_BOOLEAN:
                    pSize = 1;
                    break;

                case ELEMENT_TYPE_I:
                case ELEMENT_TYPE_U:
                case ELEMENT_TYPE_STRING:
                case ELEMENT_TYPE_PTR:
                case ELEMENT_TYPE_BYREF:
                case ELEMENT_TYPE_CLASS:
                case ELEMENT_TYPE_OBJECT:
                case ELEMENT_TYPE_FNPTR:
                case ELEMENT_TYPE_TYPEDBYREF:
                case ELEMENT_TYPE_ARRAY:
                case ELEMENT_TYPE_SZARRAY:
                    pSize = IntPtr.Size;
                    break;

                case ELEMENT_TYPE_VOID:
                    break;

                case ELEMENT_TYPE_END:
                case ELEMENT_TYPE_CMOD_REQD:
                case ELEMENT_TYPE_CMOD_OPT:
                case ELEMENT_TYPE_VALUETYPE:
                    Debug.Fail("Asked for the size of an element that doesn't have a size!");
                    return false;

                default:
                    Debug.Fail("CorSigGetElementTypeSize given invalid signature to size!");
                    return false;
            }

            return true;
        }

        private bool AtSentinel()
        {
            if (_len > 0)
                return _sig[_offs] == ELEMENT_TYPE_SENTINEL;

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

        private bool SkipFunkyAndCustomModifiers()
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
        } // SkipFunkyAndCustomModifiers

        private bool SkipAnyVASentinel()
        {
            if (!PeekByte(out byte bElementType))
                return false;

            if (bElementType == ELEMENT_TYPE_SENTINEL)
                SkipBytes(1);

            return true;
        } // SkipAnyVASentinel


    public static bool primitive(ClrElementType src)
    {
        return src >= ClrElementType.Boolean && src <= ClrElementType.Double
            || src == ClrElementType.NativeInt || src == ClrElementType.NativeUInt
            || src == ClrElementType.Pointer || src == ClrElementType.FunctionPointer;
    }

        public bool SkipExactlyOne()
        {
            if (!GetElemType(out int typ))
                return false;

            if (!primitive(((ClrElementType)typ)))
            {
                switch (typ)
                {
                    default:
                        return false;

                    case ELEMENT_TYPE_VAR:
                    case ELEMENT_TYPE_MVAR:
                        if (!GetData(out _))
                            return false;

                        break;

                    case ELEMENT_TYPE_OBJECT:
                    case ELEMENT_TYPE_STRING:
                    case ELEMENT_TYPE_TYPEDBYREF:
                        break;

                    case ELEMENT_TYPE_BYREF:
                    case ELEMENT_TYPE_PTR:
                    case ELEMENT_TYPE_PINNED:
                    case ELEMENT_TYPE_SZARRAY:
                        if (!SkipExactlyOne())
                            return false;

                        break;

                    case ELEMENT_TYPE_VALUETYPE:
                    case ELEMENT_TYPE_CLASS:
                        if (!GetToken(out _))
                            return false;

                        break;

                    case ELEMENT_TYPE_FNPTR:
                        if (!SkipSignature())
                            return false;

                        break;

                    case ELEMENT_TYPE_ARRAY:
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

                    case ELEMENT_TYPE_SENTINEL:
                        // Should be unreachable since GetElem strips it
                        break;

                    case ELEMENT_TYPE_INTERNAL:
                        if (!GetData(out _))
                            return false;

                        break;

                    case ELEMENT_TYPE_GENERICINST:
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

        private bool SkipMethodHeaderSignature(out int pcArgs)
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
        } // SigParser::SkipMethodHeaderSignature

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

        private bool UncompressToken(out int token, out int size)
        {
            if (!UncompressData(out token, out size))
                return false;

            int tkType = s_tkCorEncodeToken[token & 3];
            token = (token >> 2) | tkType;
            return true;
        }

        private byte GetSig(int offs)
        {
            return _sig[_offs + offs];
        }

        private bool UncompressData(out int pDataOut, out int pDataLen)
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

        private bool PeekByte(out int data)
        {
            if (!PeekByte(out byte tmp))
            {
                data = 0xcc;
                return false;
            }

            data = tmp;
            return true;
        }
    }
}