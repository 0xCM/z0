//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Describes an HRESULT error or success condition.
    /// </summary>
    /// <remarks>
    ///  HRESULTs are 32 bit values layed out as follows:
    /// <code>
    ///   3 3 2 2 2 2 2 2 2 2 2 2 1 1 1 1 1 1 1 1 1 1
    ///   1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0 9 8 7 6 5 4 3 2 1 0
    ///  +-+-+-+-+-+---------------------+-------------------------------+
    ///  |S|R|C|N|r|    Facility         |               Code            |
    ///  +-+-+-+-+-+---------------------+-------------------------------+
    ///
    ///  where
    ///
    ///      S - Severity - indicates success/fail
    ///
    ///          0 - Success
    ///          1 - Fail (COERROR)
    ///
    ///      R - reserved portion of the facility code, corresponds to NT's
    ///              second severity bit.
    ///
    ///      C - reserved portion of the facility code, corresponds to NT's
    ///              C field.
    ///
    ///      N - reserved portion of the facility code. Used to indicate a
    ///              mapped NT status value.
    ///
    ///      r - reserved portion of the facility code. Reserved for internal
    ///              use. Used to indicate HRESULT values that are not status
    ///              values, but are instead message ids for display strings.
    ///
    ///      Facility - is the facility code
    ///
    ///      Code - is the facility's status code
    /// </code>
    /// </remarks>
    [DebuggerDisplay("{Value}")]
    public struct HResult : IComparable, IComparable<HResult>, IEquatable<HResult>, IFormattable
    {

        /// <summary>
        /// Common HRESULT constants.
        /// </summary>
        public enum Code : uint
        {
            /// <summary>
            /// Operation successful, and returned a false result.
            /// </summary>
            S_FALSE = 1,

            /// <summary>
            /// Operation successful
            /// </summary>
            S_OK = 0,

            /// <summary>
            /// Unspecified failure
            /// </summary>
            E_FAIL = 0x80004005,

            /// <summary>
            /// Operation aborted
            /// </summary>
            E_ABORT = 0x80004004,

            /// <summary>
            /// General access denied error
            /// </summary>
            E_ACCESSDENIED = 0x80070005,

            /// <summary>
            /// Handle that is not valid
            /// </summary>
            E_HANDLE = 0x80070006,

            /// <summary>
            /// One or more arguments are not valid
            /// </summary>
            E_INVALIDARG = 0x80070057,

            /// <summary>
            /// No such interface supported
            /// </summary>
            E_NOINTERFACE = 0x80004002,

            /// <summary>
            /// Not implemented
            /// </summary>
            E_NOTIMPL = 0x80004001,

            /// <summary>
            /// Failed to allocate necessary memory
            /// </summary>
            E_OUTOFMEMORY = 0x8007000E,

            /// <summary>
            /// Pointer that is not valid
            /// </summary>
            E_POINTER = 0x80004003,

            /// <summary>
            /// Unexpected failure
            /// </summary>
            E_UNEXPECTED = 0x8000FFFF,

            /// <summary>
            /// The call was already canceled
            /// </summary>
            RPC_E_CALL_CANCELED = 0x80010002,

            /// <summary>
            /// The call was completed during the timeout interval
            /// </summary>
            RPC_E_CALL_COMPLETE = 0x80010117,

            /// <summary>
            /// Call cancellation is not enabled on the specified thread
            /// </summary>
            CO_E_CANCEL_DISABLED = 0x80010140,
        }        


        /// <summary>
        /// HRESULT facility codes defined by winerror.h.
        /// </summary>
        public enum FacilityCode : uint
        {
            FACILITY_XPS = 82 << FacilityShift,
            FACILITY_XAML = 43 << FacilityShift,
            FACILITY_USN = 129 << FacilityShift,
            FACILITY_BLBUI = 128 << FacilityShift,
            FACILITY_SPP = 256 << FacilityShift,
            FACILITY_WSB_ONLINE = 133 << FacilityShift,
            FACILITY_DLS = 153 << FacilityShift,
            FACILITY_BLB_CLI = 121 << FacilityShift,
            FACILITY_BLB = 120 << FacilityShift,
            FACILITY_WSBAPP = 122 << FacilityShift,
            FACILITY_WPN = 62 << FacilityShift,
            FACILITY_WMAAECMA = 1996 << FacilityShift,
            FACILITY_WINRM = 51 << FacilityShift,
            FACILITY_WINPE = 61 << FacilityShift,
            FACILITY_WINDOWSUPDATE = 36 << FacilityShift,
            FACILITY_WINDOWS_STORE = 63 << FacilityShift,
            FACILITY_WINDOWS_SETUP = 48 << FacilityShift,
            FACILITY_WINDOWS_DEFENDER = 80 << FacilityShift,
            FACILITY_WINDOWS_CE = 24 << FacilityShift,
            FACILITY_WINDOWS = 8 << FacilityShift,
            FACILITY_WINCODEC_DWRITE_DWM = 2200 << FacilityShift,
            FACILITY_WIA = 33 << FacilityShift,
            FACILITY_WER = 27 << FacilityShift,
            FACILITY_WEP = 2049 << FacilityShift,
            FACILITY_WEB_SOCKET = 886 << FacilityShift,
            FACILITY_WEB = 885 << FacilityShift,
            FACILITY_USERMODE_VOLSNAP = 130 << FacilityShift,
            FACILITY_USERMODE_VOLMGR = 56 << FacilityShift,
            FACILITY_VISUALCPP = 109 << FacilityShift,
            FACILITY_USERMODE_VIRTUALIZATION = 55 << FacilityShift,
            FACILITY_USERMODE_VHD = 58 << FacilityShift,
            FACILITY_URT = 19 << FacilityShift,
            FACILITY_UMI = 22 << FacilityShift,
            FACILITY_UI = 42 << FacilityShift,
            FACILITY_TPM_SOFTWARE = 41 << FacilityShift,
            FACILITY_TPM_SERVICES = 40 << FacilityShift,
            FACILITY_TIERING = 131 << FacilityShift,
            FACILITY_SYNCENGINE = 2050 << FacilityShift,
            FACILITY_SXS = 23 << FacilityShift,
            FACILITY_STORAGE = 3 << FacilityShift,
            FACILITY_STATE_MANAGEMENT = 34 << FacilityShift,
            FACILITY_SSPI = 9 << FacilityShift,
            FACILITY_USERMODE_SPACES = 231 << FacilityShift,
            FACILITY_SOS = 160 << FacilityShift,
            FACILITY_SCARD = 16 << FacilityShift,
            FACILITY_SHELL = 39 << FacilityShift,
            FACILITY_SETUPAPI = 15 << FacilityShift,
            FACILITY_SECURITY = 9 << FacilityShift,
            FACILITY_SDIAG = 60 << FacilityShift,
            FACILITY_USERMODE_SDBUS = 2305 << FacilityShift,
            FACILITY_RPC = 1 << FacilityShift,
            FACILITY_RESTORE = 256 << FacilityShift,
            FACILITY_SCRIPT = 112 << FacilityShift,
            FACILITY_PARSE = 113 << FacilityShift,
            FACILITY_RAS = 83 << FacilityShift,
            FACILITY_POWERSHELL = 84 << FacilityShift,
            FACILITY_PLA = 48 << FacilityShift,
            FACILITY_PIDGENX = 2561 << FacilityShift,
            FACILITY_P2P_INT = 98 << FacilityShift,
            FACILITY_P2P = 99 << FacilityShift,
            FACILITY_OPC = 81 << FacilityShift,
            FACILITY_ONLINE_ID = 134 << FacilityShift,
            FACILITY_WIN32 = 7 << FacilityShift,
            FACILITY_CONTROL = 10 << FacilityShift,
            FACILITY_WEBSERVICES = 61 << FacilityShift,
            FACILITY_NULL = 0 << FacilityShift,
            FACILITY_NDIS = 52 << FacilityShift,
            FACILITY_NAP = 39 << FacilityShift,
            FACILITY_MOBILE = 1793 << FacilityShift,
            FACILITY_METADIRECTORY = 35 << FacilityShift,
            FACILITY_MSMQ = 14 << FacilityShift,
            FACILITY_MEDIASERVER = 13 << FacilityShift,
            FACILITY_MBN = 84 << FacilityShift,
            FACILITY_LINGUISTIC_SERVICES = 305 << FacilityShift,
            FACILITY_LEAP = 2184 << FacilityShift,
            FACILITY_JSCRIPT = 2306 << FacilityShift,
            FACILITY_INTERNET = 12 << FacilityShift,
            FACILITY_ITF = 4 << FacilityShift,
            FACILITY_INPUT = 64 << FacilityShift,
            FACILITY_USERMODE_HYPERVISOR = 53 << FacilityShift,
            FACILITY_ACCELERATOR = 1536 << FacilityShift,
            FACILITY_HTTP = 25 << FacilityShift,
            FACILITY_GRAPHICS = 38 << FacilityShift,
            FACILITY_FWP = 50 << FacilityShift,
            FACILITY_FVE = 49 << FacilityShift,
            FACILITY_USERMODE_FILTER_MANAGER = 31 << FacilityShift,
            FACILITY_EAS = 85 << FacilityShift,
            FACILITY_EAP = 66 << FacilityShift,
            FACILITY_DXGI_DDI = 2171 << FacilityShift,
            FACILITY_DXGI = 2170 << FacilityShift,
            FACILITY_DPLAY = 21 << FacilityShift,
            FACILITY_DMSERVER = 256 << FacilityShift,
            FACILITY_DISPATCH = 2 << FacilityShift,
            FACILITY_DIRECTORYSERVICE = 37 << FacilityShift,
            FACILITY_DIRECTMUSIC = 2168 << FacilityShift,
            FACILITY_DIRECT3D11 = 2172 << FacilityShift,
            FACILITY_DIRECT3D10 = 2169 << FacilityShift,
            FACILITY_DIRECT2D = 2201 << FacilityShift,
            FACILITY_DAF = 100 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_UTIL = 260 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 272 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_TFTP = 264 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_PXE = 263 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 289 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 290 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 259 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_IMAGING = 258 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 278 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_SERVER = 257 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 293 << FacilityShift,
            FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 261 << FacilityShift,
            FACILITY_DEFRAG = 2304 << FacilityShift,
            FACILITY_DEBUGGERS = 176 << FacilityShift,
            FACILITY_CONFIGURATION = 33 << FacilityShift,
            FACILITY_COMPLUS = 17 << FacilityShift,
            FACILITY_USERMODE_COMMONLOG = 26 << FacilityShift,
            FACILITY_CMI = 54 << FacilityShift,
            FACILITY_CERT = 11 << FacilityShift,
            FACILITY_BLUETOOTH_ATT = 101 << FacilityShift,
            FACILITY_BCD = 57 << FacilityShift,
            FACILITY_BACKGROUNDCOPY = 32 << FacilityShift,
            FACILITY_AUDIOSTREAMING = 1094 << FacilityShift,
            FACILITY_AUDCLNT = 2185 << FacilityShift,
            FACILITY_AUDIO = 102 << FacilityShift,
            FACILITY_ACTION_QUEUE = 44 << FacilityShift,
            FACILITY_ACS = 20 << FacilityShift,
            FACILITY_AAF = 18 << FacilityShift,
            FACILITY_NT_BIT = 4096 << FacilityShift,
        }

        /// <summary>
        /// HRESULT severity codes defined by winerror.h.
        /// </summary>
        public enum SeverityCode : uint
        {
            Success = 0,
            Fail = 0x80000000,
        }

        /// <summary>
        /// The mask of the bits that describe the <see cref="Severity"/>.
        /// </summary>
        private const uint SeverityMask = 0x80000000;

        /// <summary>
        /// The number of bits that <see cref="Severity"/> values are shifted
        /// in order to fit within <see cref="SeverityMask"/>.
        /// </summary>
        private const int SeverityShift = 31;

        /// <summary>
        /// The mask of the bits that describe the <see cref="Facility"/>.
        /// </summary>
        private const int FacilityMask = 0x7ff0000;

        /// <summary>
        /// The number of bits that <see cref="Facility"/> values are shifted
        /// in order to fit within <see cref="FacilityMask"/>.
        /// </summary>
        private const int FacilityShift = 16;

        /// <summary>
        /// The mask of the bits that describe the <see cref="FacilityStatus"/>.
        /// </summary>
        private const int FacilityStatusMask = 0xffff;

        /// <summary>
        /// The number of bits that <see cref="FacilityStatus"/> values are shifted
        /// in order to fit within <see cref="FacilityStatusMask"/>.
        /// </summary>
        private const int FacilityStatusShift = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="HResult"/> struct.
        /// </summary>
        /// <param name="value">The value of the HRESULT.</param>
        public HResult(Code value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HResult"/> struct.
        /// </summary>
        /// <param name="value">The value of the HRESULT.</param>
        public HResult(int value)
            : this((Code)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HResult"/> struct.
        /// </summary>
        /// <param name="value">The value of the HRESULT.</param>
        public HResult(uint value)
            : this((Code)value)
        {
        }

        /// <summary>
        /// Gets the full HRESULT value, as a <see cref="Code"/> enum.
        /// </summary>
        public Code Value { get; }

        /// <summary>
        /// Gets the HRESULT as a 32-bit signed integer.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AsInt32 => (int)this.Value;

        /// <summary>
        /// Gets the HRESULT as a 32-bit unsigned integer.
        /// </summary>
        public uint AsUInt32 => (uint)this.Value;

        /// <summary>
        /// Gets a value indicating whether this HRESULT represents a successful operation.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool Succeeded => this.Severity == SeverityCode.Success;

        /// <summary>
        /// Gets a value indicating whether this HRESULT represents a failured operation.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool Failed => this.Severity == SeverityCode.Fail;

        /// <summary>
        /// Gets the facility code of the HRESULT.
        /// </summary>
        public FacilityCode Facility => (FacilityCode)(this.AsUInt32 & FacilityMask);

        /// <summary>
        /// Gets the severity of the HRESULT.
        /// </summary>
        public SeverityCode Severity => (SeverityCode)(this.AsUInt32 & SeverityMask);

        /// <summary>
        /// Gets the facility's status code bits from the HRESULT.
        /// </summary>
        public uint FacilityStatus => this.AsUInt32 & FacilityStatusMask;

        /// <summary>
        /// Converts an <see cref="int"/> into an <see cref="HResult"/>.
        /// </summary>
        /// <param name="hr">The value of the HRESULT.</param>
        public static implicit operator HResult(int hr) => new HResult(hr);

        /// <summary>
        /// Converts an <see cref="HResult"/> into an <see cref="int"/>.
        /// </summary>
        /// <param name="hr">The value of the HRESULT.</param>
        public static implicit operator int(HResult hr) => hr.AsInt32;

        /// <summary>
        /// Converts an <see cref="uint"/> into an <see cref="HResult"/>.
        /// </summary>
        /// <param name="hr">The value of the HRESULT.</param>
        public static implicit operator HResult(uint hr) => new HResult(hr);

        /// <summary>
        /// Converts an <see cref="HResult"/> into an <see cref="uint"/>.
        /// </summary>
        /// <param name="hr">The value of the HRESULT.</param>
        public static explicit operator uint(HResult hr) => hr.AsUInt32;

        /// <summary>
        /// Converts a <see cref="Code"/> enum to its structural <see cref="HResult"/> representation.
        /// </summary>
        /// <param name="hr">The value to convert.</param>
        public static implicit operator HResult(Code hr) => new HResult(hr);

        /// <summary>
        /// Converts an <see cref="HResult"/> to its <see cref="Code"/> enum representation.
        /// </summary>
        /// <param name="hr">The value to convert.</param>
        public static implicit operator Code(HResult hr) => hr.Value;

        /// <summary>
        /// Checks equality between this HResult and a <see cref="uint"/> value.
        /// </summary>
        /// <param name="hr">An <see cref="HResult"/>.</param>
        /// <param name="value">Some <see cref="uint"/> value.</param>
        /// <returns><c>true</c> if they equal; <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This operator overload is useful because HResult-uint conversion must be explicit,
        /// and without this overload, it makes comparing HResults to 0x8xxxxxxx values require casts.
        /// </remarks>
        public static bool operator ==(HResult hr, uint value) => hr.AsUInt32 == value;

        /// <summary>
        /// Checks inequality between this HResult and a <see cref="uint"/> value.
        /// </summary>
        /// <param name="hr">An <see cref="HResult"/>.</param>
        /// <param name="value">Some <see cref="uint"/> value.</param>
        /// <returns><c>true</c> if they unequal; <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This operator overload is useful because HResult-uint conversion must be explicit,
        /// and without this overload, it makes comparing HResults to 0x8xxxxxxx values require casts.
        /// </remarks>
        public static bool operator !=(HResult hr, uint value) => hr.AsUInt32 != value;

        /// <summary>
        /// Throws an exception if this HRESULT <see cref="Failed"/>, based on the failure value.
        /// </summary>
        public void ThrowOnFailure()
        {
            Marshal.ThrowExceptionForHR(this.AsInt32);
        }

        /// <summary>
        /// Throws an exception if this HRESULT <see cref="Failed"/>, based on the failure value and the specified IErrorInfo interface.
        /// </summary>
        /// <param name="errorInfo">
        /// A pointer to the IErrorInfo interface that provides more information about the
        /// error. You can specify IntPtr(0) to use the current IErrorInfo interface, or
        /// IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception
        /// just from the error code.
        /// </param>
        public void ThrowOnFailure(IntPtr errorInfo)
        {
            Marshal.ThrowExceptionForHR(this.AsInt32, errorInfo);
        }

        /// <summary>
        /// Gets an exception that represents this <see cref="HResult" />
        /// if it represents a failure.
        /// </summary>
        /// <returns>
        /// The exception, if applicable; otherwise null.
        /// </returns>
        public Exception GetException() => Marshal.GetExceptionForHR(this);

        /// <summary>
        /// Gets an exception that represents this <see cref="HResult" />
        /// if it represents a failure.
        /// </summary>
        /// <param name="errorInfo">
        /// A pointer to additional error information that may be used to populate the Exception.
        /// </param>
        /// <returns>
        /// The exception, if applicable; otherwise null.
        /// </returns>
        public Exception GetException(IntPtr errorInfo) => Marshal.GetExceptionForHR(this, errorInfo);

        /// <inheritdoc />
        public override int GetHashCode() => this.AsInt32;

        /// <inheritdoc />
        public bool Equals(HResult other) => this.Value == other.Value;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is HResult && this.Equals((HResult)obj);

        /// <inheritdoc />
        public int CompareTo(object obj) => ((IComparable)this.Value).CompareTo(obj);

        /// <inheritdoc />
        public int CompareTo(HResult other) => this.Value.CompareTo(other.Value);

        /// <inheritdoc />
        public override string ToString() => this.Value.ToString();

        /// <inheritdoc />
        public string ToString(string format, IFormatProvider formatProvider) => this.AsUInt32.ToString(format, formatProvider);
    }
}