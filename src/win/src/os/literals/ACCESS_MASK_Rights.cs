
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    [Flags]
    public enum GenericRight : uint
    {
        GENERIC_ALL = 0x10000000,
        
        GENERIC_EXECUTE = 0x20000000,
        
        GENERIC_WRITE = 0x40000000,
        
        GENERIC_READ = 0x80000000,
    }

    [Flags]
    public enum SpecialRight : uint
    {
        /// <summary>
        /// It is used to indicate access to a system access control list (SACL). This type of access requires the calling process to have the SE_SECURITY_NAME (Manage auditing and security log) privilege. If this flag is set in the access mask of an audit access ACE (successful or unsuccessful access), the SACL access will be audited.
        /// </summary>
        ACCESS_SYSTEM_SECURITY = 0x01000000,

        /// <summary>
        /// Maximum allowed.
        /// </summary>
        MAXIMUM_ALLOWED = 0x02000000,
    }

    /// <summary>
    /// Contains the object's standard access rights.
    /// </summary>
    [Flags]
    public enum StandardRight : uint
    {
        /// <summary>
        /// Delete access.
        /// </summary>
        DELETE = 0x00010000,

        /// <summary>
        /// Read access to the owner, group, and discretionary access control list (DACL) of the security descriptor.
        /// </summary>
        READ_CONTROL = 0x00020000,

        /// <summary>
        /// Write access to the DACL.
        /// </summary>
        WRITE_DAC = 0x00040000,

        /// <summary>
        /// Write access to owner.
        /// </summary>
        WRITE_OWNER = 0x00080000,

        /// <summary>
        /// Synchronize access.
        /// </summary>
        SYNCHRONIZE = 0x00100000,

        STANDARD_RIGHTS_REQUIRED = 0x000F0000,

        /// <summary>
        /// See also <see cref="READ_CONTROL"/>
        /// </summary>
        STANDARD_RIGHTS_READ = READ_CONTROL,

        /// <summary>
        /// See also <see cref="READ_CONTROL"/>
        /// </summary>
        STANDARD_RIGHTS_WRITE = READ_CONTROL,

        /// <summary>
        /// See also <see cref="READ_CONTROL"/>
        /// </summary>
        STANDARD_RIGHTS_EXECUTE = READ_CONTROL,

        STANDARD_RIGHTS_ALL = 0x001F0000,
    }

    /// <summary>
    /// Contains the access mask specific to the object type associated with the mask.
    /// </summary>
    [Flags]
    public enum SpecificRight : uint
    {
        /// <summary>
        /// The bit mask that covers specific rights.
        /// </summary>
        SPECIFIC_RIGHTS_ALL = 0x0000FFFF,
    }

    /// <summary>
    /// The following are the generic access rights for a desktop object contained in the interactive window station of the user's logon session.
    /// </summary>
    [Flags]
    public enum DesktopGenericRight : uint
    {
        GENERIC_READ = StandardRight.STANDARD_RIGHTS_READ |
            DesktopSpecificRight.DESKTOP_ENUMERATE |
            DesktopSpecificRight.DESKTOP_READOBJECTS,

        GENERIC_WRITE = StandardRight.STANDARD_RIGHTS_WRITE |
            DesktopSpecificRight.DESKTOP_CREATEMENU |
            DesktopSpecificRight.DESKTOP_CREATEWINDOW |
            DesktopSpecificRight.DESKTOP_HOOKCONTROL |
            DesktopSpecificRight.DESKTOP_JOURNALPLAYBACK |
            DesktopSpecificRight.DESKTOP_JOURNALRECORD |
            DesktopSpecificRight.DESKTOP_WRITEOBJECTS,

        GENERIC_EXECUTE = StandardRight.STANDARD_RIGHTS_EXECUTE |
            DesktopSpecificRight.DESKTOP_SWITCHDESKTOP,

        GENERIC_ALL = StandardRight.STANDARD_RIGHTS_REQUIRED |
            DesktopSpecificRight.DESKTOP_CREATEMENU |
            DesktopSpecificRight.DESKTOP_CREATEWINDOW |
            DesktopSpecificRight.DESKTOP_ENUMERATE |
            DesktopSpecificRight.DESKTOP_HOOKCONTROL |
            DesktopSpecificRight.DESKTOP_JOURNALPLAYBACK |
            DesktopSpecificRight.DESKTOP_JOURNALRECORD |
            DesktopSpecificRight.DESKTOP_READOBJECTS |
            DesktopSpecificRight.DESKTOP_SWITCHDESKTOP |
            DesktopSpecificRight.DESKTOP_WRITEOBJECTS,
    }

    /// <summary>
    /// Contains the access mask specific to the Desktop associated with the mask.
    /// </summary>
    [Flags]
    public enum DesktopSpecificRight : uint
    {
        /// <summary>
        /// The bit mask that covers all possible access rights for the desktop.
        /// </summary>
        DESKTOP_ALL_ACCESS = 0x000001FF,

        /// <summary>
        /// Required to create a menu on the desktop.
        /// </summary>
        DESKTOP_CREATEMENU = 0x00000004,

        /// <summary>
        /// Required for the desktop to be enumerated.
        /// </summary>
        DESKTOP_ENUMERATE = 0x00000040,

        /// <summary>
        /// Required to establish any of the window hooks.
        /// </summary>
        DESKTOP_HOOKCONTROL = 0x00000008,

        /// <summary>
        /// Required to perform journal playback on a desktop.
        /// </summary>
        DESKTOP_JOURNALPLAYBACK = 0x00000020,

        /// <summary>
        /// Required to perform journal recording on a desktop.
        /// </summary>
        DESKTOP_JOURNALRECORD = 0x00000010,

        /// <summary>
        /// Required to read objects on the desktop.
        /// </summary>
        DESKTOP_READOBJECTS = 0x00000001,

        /// <summary>
        /// Required to create a window on the desktop.
        /// </summary>
        DESKTOP_CREATEWINDOW = 0x00000002,

        /// <summary>
        /// Required to activate the desktop using the SwitchDesktop function.
        /// </summary>
        DESKTOP_SWITCHDESKTOP = 0x00000100,

        /// <summary>
        /// Required to write objects on the desktop.
        /// </summary>
        DESKTOP_WRITEOBJECTS = 0x00000080,
    }

    /// <summary>
    /// Generic access rights for the interactive window station object, which is the window station assigned to the logon session of the interactive user.
    /// </summary>
    [Flags]
    public enum InteractiveWindowStationGenericRight : uint
    {
        GENERIC_READ = StandardRight.STANDARD_RIGHTS_READ |
            WindowStationSpecificRight.WINSTA_ENUMDESKTOPS |
            WindowStationSpecificRight.WINSTA_ENUMERATE |
            WindowStationSpecificRight.WINSTA_READATTRIBUTES |
            WindowStationSpecificRight.WINSTA_READSCREEN,

        GENERIC_WRITE = StandardRight.STANDARD_RIGHTS_WRITE |
            WindowStationSpecificRight.WINSTA_ACCESSCLIPBOARD |
            WindowStationSpecificRight.WINSTA_CREATEDESKTOP |
            WindowStationSpecificRight.WINSTA_WRITEATTRIBUTES,

        GENERIC_EXECUTE = StandardRight.STANDARD_RIGHTS_EXECUTE |
            WindowStationSpecificRight.WINSTA_ACCESSGLOBALATOMS |
            WindowStationSpecificRight.WINSTA_EXITWINDOWS,

        GENERIC_ALL = StandardRight.STANDARD_RIGHTS_REQUIRED |
            WindowStationSpecificRight.WINSTA_ACCESSCLIPBOARD |
            WindowStationSpecificRight.WINSTA_ACCESSGLOBALATOMS |
            WindowStationSpecificRight.WINSTA_CREATEDESKTOP |
            WindowStationSpecificRight.WINSTA_ENUMDESKTOPS |
            WindowStationSpecificRight.WINSTA_ENUMERATE |
            WindowStationSpecificRight.WINSTA_EXITWINDOWS |
            WindowStationSpecificRight.WINSTA_READATTRIBUTES |
            WindowStationSpecificRight.WINSTA_READSCREEN |
            WindowStationSpecificRight.WINSTA_WRITEATTRIBUTES,
    }

    /// <summary>
    /// Generic access rights for a noninteractive window station object.
    /// The system assigns noninteractive window stations to all logon sessions other than that of the interactive user.
    /// </summary>
    [Flags]
    public enum NonInteractiveWindowStationGenericRight : uint
    {
        GENERIC_READ = StandardRight.STANDARD_RIGHTS_READ |
            WindowStationSpecificRight.WINSTA_ENUMDESKTOPS |
            WindowStationSpecificRight.WINSTA_ENUMERATE |
            WindowStationSpecificRight.WINSTA_READATTRIBUTES,

        GENERIC_WRITE = StandardRight.STANDARD_RIGHTS_WRITE |
            WindowStationSpecificRight.WINSTA_ACCESSCLIPBOARD |
            WindowStationSpecificRight.WINSTA_CREATEDESKTOP,

        GENERIC_EXECUTE = StandardRight.STANDARD_RIGHTS_EXECUTE |
            WindowStationSpecificRight.WINSTA_ACCESSGLOBALATOMS |
            WindowStationSpecificRight.WINSTA_EXITWINDOWS,

        GENERIC_ALL = StandardRight.STANDARD_RIGHTS_REQUIRED |
            WindowStationSpecificRight.WINSTA_ACCESSCLIPBOARD |
            WindowStationSpecificRight.WINSTA_ACCESSGLOBALATOMS |
            WindowStationSpecificRight.WINSTA_CREATEDESKTOP |
            WindowStationSpecificRight.WINSTA_ENUMDESKTOPS |
            WindowStationSpecificRight.WINSTA_ENUMERATE |
            WindowStationSpecificRight.WINSTA_EXITWINDOWS |
            WindowStationSpecificRight.WINSTA_READATTRIBUTES |
            WindowStationSpecificRight.WINSTA_READSCREEN,
    }

    /// <summary>
    /// Contains the access mask specific to the Window Station associated with the mask.
    /// </summary>
    [Flags]
    public enum WindowStationSpecificRight : uint
    {
        /// <summary>
        /// The bit mask that covers all possible access rights for the window station.
        /// </summary>
        WINSTA_ALL_ACCESS = 0x0000037F,

        /// <summary>
        /// Required to use the clipboard.
        /// </summary>
        WINSTA_ACCESSCLIPBOARD = 0x00000004,

        /// <summary>
        /// Required to manipulate global atoms.
        /// </summary>
        WINSTA_ACCESSGLOBALATOMS = 0x00000020,

        /// <summary>
        /// Required to create new desktop objects on the window station.
        /// </summary>
        WINSTA_CREATEDESKTOP = 0x00000008,

        /// <summary>
        /// Required to enumerate existing desktop objects.
        /// </summary>
        WINSTA_ENUMDESKTOPS = 0x00000001,

        /// <summary>
        /// Required for the window station to be enumerated.
        /// </summary>
        WINSTA_ENUMERATE = 0x00000100,

        /// <summary>
        /// Required to successfully call the ExitWindows or ExitWindowsEx function
        /// Window stations can be shared by users and this access type can prevent other users of a window station from logging off the window station owner.
        /// </summary>
        WINSTA_EXITWINDOWS = 0x00000040,

        /// <summary>
        /// Required to read the attributes of a window station object. This attribute includes color settings and other global window station properties.
        /// </summary>
        WINSTA_READATTRIBUTES = 0x00000002,

        /// <summary>
        /// Required to access screen contents.
        /// </summary>
        WINSTA_READSCREEN = 0x00000200,

        /// <summary>
        /// Required to modify the attributes of a window station object. The attributes include color settings and other global window station properties.
        /// </summary>
        WINSTA_WRITEATTRIBUTES = 0x00000010,
    }
}