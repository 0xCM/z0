//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;


    /*****************************************************************************\
    *                                                                             *
    * CorInfo.h -    EE / Code generator interface                                *
    *                                                                             *
    *******************************************************************************
    *
    * This file exposes CLR runtime functionality. It can be used by compilers,
    * both Just-in-time and ahead-of-time, to generate native code which
    * executes in the runtime environment.
    *******************************************************************************

    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    // NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE
    //
    // The JIT/EE interface is versioned. By "interface", we mean mean any and all communication between the
    // JIT and the EE. Any time a change is made to the interface, the JIT/EE interface version identifier
    // must be updated. See code:JITEEVersionIdentifier for more information.
    //
    // NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE
    //
    //////////////////////////////////////////////////////////////////////////////////////////////////////////

    #EEJitContractDetails

    The semantic contract between the EE and the JIT should be documented here It is incomplete, but as time goes
    on, that hopefully will change

    See file:../../doc/BookOfTheRuntime/JIT/JIT%20Design.doc for details on the JIT compiler. See
    code:EEStartup#TableOfContents for information on the runtime as a whole.

    -------------------------------------------------------------------------------
    #Tokens

    The tokens in IL stream needs to be resolved to EE handles (CORINFO_CLASS/METHOD/FIELD_HANDLE) that
    the runtime operates with. ICorStaticInfo::resolveToken is the method that resolves the found in IL stream
    to set of EE handles (CORINFO_RESOLVED_TOKEN). All other APIs take resolved token as input. This design
    avoids redundant token resolutions.

    The token validation is done as part of token resolution. The JIT is not required to do explicit upfront
    token validation.

    -------------------------------------------------------------------------------
    #ClassConstruction

    First of all class contruction comes in two flavors precise and 'beforeFieldInit'. In C# you get the former
    if you declare an explicit class constructor method and the later if you declaratively initialize static
    fields. Precise class construction guarantees that the .cctor is run precisely before the first access to any
    method or field of the class. 'beforeFieldInit' semantics guarantees only that the .cctor will be run some
    time before the first static field access (note that calling methods (static or instance) or accessing
    instance fields does not cause .cctors to be run).

    Next you need to know that there are two kinds of code generation that can happen in the JIT: appdomain
    neutral and appdomain specialized. The difference between these two kinds of code is how statics are handled.
    For appdomain specific code, the address of a particular static variable is embedded in the code. This makes
    it usable only for one appdomain (since every appdomain gets a own copy of its statics). Appdomain neutral
    code calls a helper that looks up static variables off of a thread local variable. Thus the same code can be
    used by multiple appdomains in the same process.

    Generics also introduce a similar issue. Code for generic classes might be specialized for a particular set
    of type arguments, or it could use helpers to access data that depends on type parameters and thus be shared
    across several instantiations of the generic type.

    Thus there four cases

        * BeforeFieldInitCCtor - Unshared code. Cctors are only called when static fields are fetched. At the
            time the method that touches the static field is JITed (or fixed up in the case of NGENed code), the
            .cctor is called.
        * BeforeFieldInitCCtor - Shared code. Since the same code is used for multiple classes, the act of JITing
            the code can not be used as a hook. However, it is also the case that since the code is shared, it
            can not wire in a particular address for the static and thus needs to use a helper that looks up the
            correct address based on the thread ID. This helper does the .cctor check, and thus no additional
            cctor logic is needed.
        * PreciseCCtor - Unshared code. Any time a method is JITTed (or fixed up in the case of NGEN), a cctor
            check for the class of the method being JITTed is done. In addition the JIT inserts explicit checks
            before any static field accesses. Instance methods and fields do NOT have hooks because a .ctor
            method must be called before the instance can be created.
        * PreciseCctor - Shared code .cctor checks are placed in the prolog of every .ctor and static method. All
            methods that access static fields have an explicit .cctor check before use. Again instance methods
            don't have hooks because a .ctor would have to be called first.

    Technically speaking, however the optimization of avoiding checks on instance methods is flawed. It requires
    that a .ctor always preceed a call to an instance methods. This break down when

        * A NULL is passed to an instance method.
        * A .ctor does not call its superclasses .ctor. This allows an instance to be created without necessarily
            calling all the .cctors of all the superclasses. A virtual call can then be made to a instance of a
            superclass without necessarily calling the superclass's .cctor.
        * The class is a value class (which exists without a .ctor being called)

    Nevertheless, the cost of plugging these holes is considered to high and the benefit is low.

    ----------------------------------------------------------------------

    #ClassConstructionFlags

    Thus the JIT's cctor responsibilities require it to check with the EE on every static field access using
    initClass and before jitting any method to see if a .cctor check must be placed in the prolog.

        * CORINFO_FLG_BEFOREFIELDINIT indicate the class has beforeFieldInit semantics. The jit does not strictly
            need this information however, it is valuable in optimizing static field fetch helper calls. Helper
            call for classes with BeforeFieldInit semantics can be hoisted before other side effects where
            classes with precise .cctor semantics do not allow this optimization.

    Inlining also complicates things. Because the class could have precise semantics it is also required that the
    inlining of any constructor or static method must also do the initClass check. The inliner has the option of
    inserting any required runtime check or simply not inlining the function.

    -------------------------------------------------------------------------------

    #StaticFields

    The first 4 options are mutually exclusive

        * CORINFO_FLG_HELPER If the field has this set, then the JIT must call getFieldHelper and call the
            returned helper with the object ref (for an instance field) and a fieldDesc. Note that this should be
            able to handle ANY field so to get a JIT up quickly, it has the option of using helper calls for all
            field access (and skip the complexity below). Note that for statics it is assumed that you will
            always ask for the ADDRESS helper and to the fetch in the JIT.

        * CORINFO_FLG_SHARED_HELPER This is currently only used for static fields. If this bit is set it means
            that the field is feched by a helper call that takes a module identifier (see getModuleDomainID) and
            a class identifier (see getClassDomainID) as arguments. The exact helper to call is determined by
            getSharedStaticBaseHelper. The return value is of this function is the base of all statics in the
            module. The offset from getFieldOffset must be added to this value to get the address of the field
            itself. (see also CORINFO_FLG_STATIC_IN_HEAP).


        * CORINFO_FLG_GENERICS_STATIC This is currently only used for static fields (of generic type). This
            function is intended to be called with a Generic handle as a argument (from embedGenericHandle). The
            exact helper to call is determined by getSharedStaticBaseHelper. The returned value is the base of
            all statics in the class. The offset from getFieldOffset must be added to this value to get the
            address of the (see also CORINFO_FLG_STATIC_IN_HEAP).

        * CORINFO_FLG_TLS This indicate that the static field is a Windows style Thread Local Static. (We also
            have managed thread local statics, which work through the HELPER. Support for this is considered
            legacy, and going forward, the EE should

        * <NONE> This is a normal static field. Its address in in memory is determined by getFieldAddress. (see
            also CORINFO_FLG_STATIC_IN_HEAP).


    This last field can modify any of the cases above except CORINFO_FLG_HELPER

    CORINFO_FLG_STATIC_IN_HEAP This is currently only used for static fields of value classes. If the field has
    this set then after computing what would normally be the field, what you actually get is a object pointer
    (that must be reported to the GC) to a boxed version of the value. Thus the actual field address is computed
    by addr = (*addr+sizeof(OBJECTREF))

    Instance fields

        * CORINFO_FLG_HELPER This is used if the class is MarshalByRef, which means that the object might be a
            proxy to the real object in some other appdomain or process. If the field has this set, then the JIT
            must call getFieldHelper and call the returned helper with the object ref. If the helper returned is
            helpers that are for structures the args are as follows

        * CORINFO_HELP_GETFIELDSTRUCT - args are: retBuff, object, fieldDesc
        * CORINFO_HELP_SETFIELDSTRUCT - args are object fieldDesc value

    The other GET helpers take an object fieldDesc and return the value The other SET helpers take an object
    fieldDesc and value

        Note that unlike static fields there is no helper to take the address of a field because in general there
        is no address for proxies (LDFLDA is illegal on proxies).

        CORINFO_FLG_EnC This is to support adding new field for edit and continue. This field also indicates that
        a helper is needed to access this field. However this helper is always CORINFO_HELP_GETFIELDADDR, and
        this helper always takes the object and field handle and returns the address of the field. It is the
                                JIT's responsibility to do the fetch or set.

    -------------------------------------------------------------------------------

    TODO: Talk about initializing strutures before use


    *******************************************************************************
    */

    public readonly struct CorInfo
    {
        //
        // NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE
        //
        // #JITEEVersionIdentifier
        //
        // This GUID represents the version of the JIT/EE interface. Any time the interface between the JIT and
        // the EE changes (by adding or removing methods to any interface shared between them), this GUID should
        // be changed. This is the identifier verified by ICorJitCompiler::getVersionIdentifier().
        //
        // You can use "uuidgen.exe -s" to generate this value.
        //
        // **** NOTE TO INTEGRATORS:
        //
        // If there is a merge conflict here, because the version changed in two different places, you must
        // create a **NEW** GUID, not simply choose one or the other!
        //
        // NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE NOTE
        //

        public static ReadOnlySpan<byte> JITEEVersionIdentifier_Data
            => new byte[16]{0x06, 0x21, 0x14, 0xd0, 0xbd,0x20,0x48,0x3f,0x8a, 0x3e, 0xc4, 0xee, 0x39, 0x70, 0x6a, 0xe8};

        public ref readonly Guid JITEEVersionIdentifier
            => ref @as<byte,Guid>(first(JITEEVersionIdentifier_Data));



        // CorInfoHelpFunc defines the set of helpers (accessed via the ICorDynamicInfo::getHelperFtn())
        // These helpers can be called by native code which executes in the runtime.
        // Compilers can emit calls to these helpers.
        //
        // The signatures of the helpers are below (see RuntimeHelperArgumentCheck)
        public enum CorInfoHelpFunc : ushort
        {
            CORINFO_HELP_UNDEF,         // invalid value. This should never be used

            /* Arithmetic helpers */

            CORINFO_HELP_DIV,           // For the ARM 32-bit integer divide uses a helper call :-(

            CORINFO_HELP_MOD,

            CORINFO_HELP_UDIV,

            CORINFO_HELP_UMOD,

            CORINFO_HELP_LLSH,

            CORINFO_HELP_LRSH,

            CORINFO_HELP_LRSZ,

            CORINFO_HELP_LMUL,

            CORINFO_HELP_LMUL_OVF,

            CORINFO_HELP_ULMUL_OVF,

            CORINFO_HELP_LDIV,

            CORINFO_HELP_LMOD,

            CORINFO_HELP_ULDIV,

            CORINFO_HELP_ULMOD,

            CORINFO_HELP_LNG2DBL,               // Convert a signed int64 to a double
            CORINFO_HELP_ULNG2DBL,              // Convert a unsigned int64 to a double
            CORINFO_HELP_DBL2INT,
            CORINFO_HELP_DBL2INT_OVF,
            CORINFO_HELP_DBL2LNG,
            CORINFO_HELP_DBL2LNG_OVF,
            CORINFO_HELP_DBL2UINT,
            CORINFO_HELP_DBL2UINT_OVF,
            CORINFO_HELP_DBL2ULNG,
            CORINFO_HELP_DBL2ULNG_OVF,
            CORINFO_HELP_FLTREM,
            CORINFO_HELP_DBLREM,
            CORINFO_HELP_FLTROUND,
            CORINFO_HELP_DBLROUND,

            /* Allocating a new object. Always use ICorClassInfo::getNewHelper() to decide
            which is the right helper to use to allocate an object of a given type. */

            CORINFO_HELP_NEWFAST,

            CORINFO_HELP_NEWSFAST,          // allocator for small, non-finalizer, non-array object

            CORINFO_HELP_NEWSFAST_FINALIZE, // allocator for small, finalizable, non-array object

            CORINFO_HELP_NEWSFAST_ALIGN8,   // allocator for small, non-finalizer, non-array object, 8 byte aligned

            CORINFO_HELP_NEWSFAST_ALIGN8_VC,// allocator for small, value class, 8 byte aligned

            CORINFO_HELP_NEWSFAST_ALIGN8_FINALIZE, // allocator for small, finalizable, non-array object, 8 byte aligned

            CORINFO_HELP_NEW_MDARR,         // multi-dim array helper (with or without lower bounds - dimensions passed in as vararg)

            CORINFO_HELP_NEW_MDARR_NONVARARG,// multi-dim array helper (with or without lower bounds - dimensions passed in as unmanaged array)

            CORINFO_HELP_NEWARR_1_DIRECT,   // helper for any one dimensional array creation

            CORINFO_HELP_NEWARR_1_OBJ,      // optimized 1-D object arrays

            CORINFO_HELP_NEWARR_1_VC,       // optimized 1-D value class arrays

            CORINFO_HELP_NEWARR_1_ALIGN8,   // like VC, but aligns the array start

            CORINFO_HELP_STRCNS,            // create a new string literal

            CORINFO_HELP_STRCNS_CURRENT_MODULE, // create a new string literal from the current module (used by NGen code)

            /* Object model */

            CORINFO_HELP_INITCLASS,         // Initialize class if not already initialized

            CORINFO_HELP_INITINSTCLASS,     // Initialize class for instantiated type

            // Use ICorClassInfo::getCastingHelper to determine
            // the right helper to use

            CORINFO_HELP_ISINSTANCEOFINTERFACE, // Optimized helper for interfaces

            CORINFO_HELP_ISINSTANCEOFARRAY,  // Optimized helper for arrays

            CORINFO_HELP_ISINSTANCEOFCLASS, // Optimized helper for classes

            CORINFO_HELP_ISINSTANCEOFANY,   // Slow helper for any type

            CORINFO_HELP_CHKCASTINTERFACE,
            CORINFO_HELP_CHKCASTARRAY,
            CORINFO_HELP_CHKCASTCLASS,
            CORINFO_HELP_CHKCASTANY,
            CORINFO_HELP_CHKCASTCLASS_SPECIAL, // Optimized helper for classes. Assumes that the trivial cases
                                            // has been taken care of by the inlined check

            CORINFO_HELP_BOX,
            CORINFO_HELP_BOX_NULLABLE,      // special form of boxing for Nullable<T>
            CORINFO_HELP_UNBOX,
            CORINFO_HELP_UNBOX_NULLABLE,    // special form of unboxing for Nullable<T>
            CORINFO_HELP_GETREFANY,         // Extract the byref from a TypedReference, checking that it is the expected type

            CORINFO_HELP_ARRADDR_ST,        // assign to element of object array with type-checking
            CORINFO_HELP_LDELEMA_REF,       // does a precise type comparision and returns address

            /* Exceptions */

            CORINFO_HELP_THROW,             // Throw an exception object
            CORINFO_HELP_RETHROW,           // Rethrow the currently active exception
            CORINFO_HELP_USER_BREAKPOINT,   // For a user program to break to the debugger
            CORINFO_HELP_RNGCHKFAIL,        // array bounds check failed
            CORINFO_HELP_OVERFLOW,          // throw an overflow exception
            CORINFO_HELP_THROWDIVZERO,      // throw a divide by zero exception
            CORINFO_HELP_THROWNULLREF,      // throw a null reference exception

            CORINFO_HELP_INTERNALTHROW,     // Support for really fast jit
            CORINFO_HELP_VERIFICATION,      // Throw a VerificationException
            CORINFO_HELP_SEC_UNMGDCODE_EXCPT, // throw a security unmanaged code exception
            CORINFO_HELP_FAIL_FAST,         // Kill the process avoiding any exceptions or stack and data dependencies (use for GuardStack unsafe buffer checks)

            CORINFO_HELP_METHOD_ACCESS_EXCEPTION,//Throw an access exception due to a failed member/class access check.
            CORINFO_HELP_FIELD_ACCESS_EXCEPTION,
            CORINFO_HELP_CLASS_ACCESS_EXCEPTION,

            CORINFO_HELP_ENDCATCH,          // call back into the EE at the end of a catch block

            /* Synchronization */

            CORINFO_HELP_MON_ENTER,
            CORINFO_HELP_MON_EXIT,
            CORINFO_HELP_MON_ENTER_STATIC,
            CORINFO_HELP_MON_EXIT_STATIC,

            CORINFO_HELP_GETCLASSFROMMETHODPARAM, // Given a generics method handle, returns a class handle
            CORINFO_HELP_GETSYNCFROMCLASSHANDLE,  // Given a generics class handle, returns the sync monitor
                                                // in its ManagedClassObject

            /* GC support */

            CORINFO_HELP_STOP_FOR_GC,       // Call GC (force a GC)
            CORINFO_HELP_POLL_GC,           // Ask GC if it wants to collect

            CORINFO_HELP_STRESS_GC,         // Force a GC, but then update the JITTED code to be a noop call
            CORINFO_HELP_CHECK_OBJ,         // confirm that ECX is a valid object pointer (debugging only)

            /* GC Write barrier support */

            CORINFO_HELP_ASSIGN_REF,        // universal helpers with F_CALL_CONV calling convention
            CORINFO_HELP_CHECKED_ASSIGN_REF,
            CORINFO_HELP_ASSIGN_REF_ENSURE_NONHEAP,  // Do the store, and ensure that the target was not in the heap.

            CORINFO_HELP_ASSIGN_BYREF,
            CORINFO_HELP_ASSIGN_STRUCT,


            /* Accessing fields */

            // For COM object support (using COM get/set routines to update object)
            // and EnC and cross-context support
            CORINFO_HELP_GETFIELD8,
            CORINFO_HELP_SETFIELD8,
            CORINFO_HELP_GETFIELD16,
            CORINFO_HELP_SETFIELD16,
            CORINFO_HELP_GETFIELD32,
            CORINFO_HELP_SETFIELD32,
            CORINFO_HELP_GETFIELD64,
            CORINFO_HELP_SETFIELD64,
            CORINFO_HELP_GETFIELDOBJ,
            CORINFO_HELP_SETFIELDOBJ,
            CORINFO_HELP_GETFIELDSTRUCT,
            CORINFO_HELP_SETFIELDSTRUCT,
            CORINFO_HELP_GETFIELDFLOAT,
            CORINFO_HELP_SETFIELDFLOAT,
            CORINFO_HELP_GETFIELDDOUBLE,
            CORINFO_HELP_SETFIELDDOUBLE,

            CORINFO_HELP_GETFIELDADDR,

            CORINFO_HELP_GETSTATICFIELDADDR_CONTEXT,    // Helper for context-static fields
            CORINFO_HELP_GETSTATICFIELDADDR_TLS,        // Helper for PE TLS fields

            // There are a variety of specialized helpers for accessing static fields. The JIT should use
            // ICorClassInfo::getSharedStaticsOrCCtorHelper to determine which helper to use

            // Helpers for regular statics
            CORINFO_HELP_GETGENERICS_GCSTATIC_BASE,
            CORINFO_HELP_GETGENERICS_NONGCSTATIC_BASE,
            CORINFO_HELP_GETSHARED_GCSTATIC_BASE,
            CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE,
            CORINFO_HELP_GETSHARED_GCSTATIC_BASE_NOCTOR,
            CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE_NOCTOR,
            CORINFO_HELP_GETSHARED_GCSTATIC_BASE_DYNAMICCLASS,
            CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE_DYNAMICCLASS,
            // Helper to class initialize shared generic with dynamicclass, but not get static field address
            CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS,

            // Helpers for thread statics
            CORINFO_HELP_GETGENERICS_GCTHREADSTATIC_BASE,
            CORINFO_HELP_GETGENERICS_NONGCTHREADSTATIC_BASE,
            CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE,
            CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE,
            CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR,
            CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR,
            CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS,
            CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_DYNAMICCLASS,

            /* Debugger */

            CORINFO_HELP_DBG_IS_JUST_MY_CODE,    // Check if this is "JustMyCode" and needs to be stepped through.

            /* Profiling enter/leave probe addresses */
            CORINFO_HELP_PROF_FCN_ENTER,        // record the entry to a method (caller)
            CORINFO_HELP_PROF_FCN_LEAVE,        // record the completion of current method (caller)
            CORINFO_HELP_PROF_FCN_TAILCALL,     // record the completion of current method through tailcall (caller)

            /* Miscellaneous */

            CORINFO_HELP_BBT_FCN_ENTER,         // record the entry to a method for collecting Tuning data

            CORINFO_HELP_PINVOKE_CALLI,         // Indirect pinvoke call
            CORINFO_HELP_TAILCALL,              // Perform a tail call

            CORINFO_HELP_GETCURRENTMANAGEDTHREADID,

            CORINFO_HELP_INIT_PINVOKE_FRAME,   // initialize an inlined PInvoke Frame for the JIT-compiler

            CORINFO_HELP_MEMSET,                // Init block of memory
            CORINFO_HELP_MEMCPY,                // Copy block of memory

            CORINFO_HELP_RUNTIMEHANDLE_METHOD,          // determine a type/field/method handle at run-time
            CORINFO_HELP_RUNTIMEHANDLE_METHOD_LOG,      // determine a type/field/method handle at run-time, with IBC logging
            CORINFO_HELP_RUNTIMEHANDLE_CLASS,           // determine a type/field/method handle at run-time
            CORINFO_HELP_RUNTIMEHANDLE_CLASS_LOG,       // determine a type/field/method handle at run-time, with IBC logging

            CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE, // Convert from a TypeHandle (native structure pointer) to RuntimeType at run-time
            CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE_MAYBENULL, // Convert from a TypeHandle (native structure pointer) to RuntimeType at run-time, the type may be null
            CORINFO_HELP_METHODDESC_TO_STUBRUNTIMEMETHOD, // Convert from a MethodDesc (native structure pointer) to RuntimeMethodHandle at run-time
            CORINFO_HELP_FIELDDESC_TO_STUBRUNTIMEFIELD, // Convert from a FieldDesc (native structure pointer) to RuntimeFieldHandle at run-time
            CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPEHANDLE, // Convert from a TypeHandle (native structure pointer) to RuntimeTypeHandle at run-time
            CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPEHANDLE_MAYBENULL, // Convert from a TypeHandle (native structure pointer) to RuntimeTypeHandle at run-time, handle might point to a null type

            CORINFO_HELP_ARE_TYPES_EQUIVALENT, // Check whether two TypeHandles (native structure pointers) are equivalent

            CORINFO_HELP_VIRTUAL_FUNC_PTR,      // look up a virtual method at run-time
            //CORINFO_HELP_VIRTUAL_FUNC_PTR_LOG,  // look up a virtual method at run-time, with IBC logging

            // Not a real helpers. Instead of taking handle arguments, these helpers point to a small stub that loads the handle argument and calls the static helper.
            CORINFO_HELP_READYTORUN_NEW,
            CORINFO_HELP_READYTORUN_NEWARR_1,
            CORINFO_HELP_READYTORUN_ISINSTANCEOF,
            CORINFO_HELP_READYTORUN_CHKCAST,
            CORINFO_HELP_READYTORUN_STATIC_BASE,
            CORINFO_HELP_READYTORUN_VIRTUAL_FUNC_PTR,
            CORINFO_HELP_READYTORUN_GENERIC_HANDLE,
            CORINFO_HELP_READYTORUN_DELEGATE_CTOR,
            CORINFO_HELP_READYTORUN_GENERIC_STATIC_BASE,

            CORINFO_HELP_EE_PRESTUB,            // Not real JIT helper. Used in native images.

            CORINFO_HELP_EE_PRECODE_FIXUP,      // Not real JIT helper. Used for Precode fixup in native images.
            CORINFO_HELP_EE_PINVOKE_FIXUP,      // Not real JIT helper. Used for PInvoke target fixup in native images.
            CORINFO_HELP_EE_VSD_FIXUP,          // Not real JIT helper. Used for VSD cell fixup in native images.
            CORINFO_HELP_EE_EXTERNAL_FIXUP,     // Not real JIT helper. Used for to fixup external method thunks in native images.
            CORINFO_HELP_EE_VTABLE_FIXUP,       // Not real JIT helper. Used for inherited vtable slot fixup in native images.

            CORINFO_HELP_EE_REMOTING_THUNK,     // Not real JIT helper. Used for remoting precode in native images.

            CORINFO_HELP_EE_PERSONALITY_ROUTINE,// Not real JIT helper. Used in native images.
            CORINFO_HELP_EE_PERSONALITY_ROUTINE_FILTER_FUNCLET,// Not real JIT helper. Used in native images to detect filter funclets.

            // ASSIGN_REF_EAX - CHECKED_ASSIGN_REF_EBP: NOGC_WRITE_BARRIERS JIT helper calls
            //
            // For unchecked versions EDX is required to point into GC heap.
            //
            // NOTE: these helpers are only used for x86.
            CORINFO_HELP_ASSIGN_REF_EAX,    // EAX holds GC ptr, do a 'mov [EDX], EAX' and inform GC
            CORINFO_HELP_ASSIGN_REF_EBX,    // EBX holds GC ptr, do a 'mov [EDX], EBX' and inform GC
            CORINFO_HELP_ASSIGN_REF_ECX,    // ECX holds GC ptr, do a 'mov [EDX], ECX' and inform GC
            CORINFO_HELP_ASSIGN_REF_ESI,    // ESI holds GC ptr, do a 'mov [EDX], ESI' and inform GC
            CORINFO_HELP_ASSIGN_REF_EDI,    // EDI holds GC ptr, do a 'mov [EDX], EDI' and inform GC
            CORINFO_HELP_ASSIGN_REF_EBP,    // EBP holds GC ptr, do a 'mov [EDX], EBP' and inform GC

            CORINFO_HELP_CHECKED_ASSIGN_REF_EAX,  // These are the same as ASSIGN_REF above ...
            CORINFO_HELP_CHECKED_ASSIGN_REF_EBX,  // ... but also check if EDX points into heap.
            CORINFO_HELP_CHECKED_ASSIGN_REF_ECX,
            CORINFO_HELP_CHECKED_ASSIGN_REF_ESI,
            CORINFO_HELP_CHECKED_ASSIGN_REF_EDI,
            CORINFO_HELP_CHECKED_ASSIGN_REF_EBP,

            CORINFO_HELP_LOOP_CLONE_CHOICE_ADDR, // Return the reference to a counter to decide to take cloned path in debug stress.
            CORINFO_HELP_DEBUG_LOG_LOOP_CLONING, // Print a message that a loop cloning optimization has occurred in debug mode.

            CORINFO_HELP_THROW_ARGUMENTEXCEPTION,           // throw ArgumentException
            CORINFO_HELP_THROW_ARGUMENTOUTOFRANGEEXCEPTION, // throw ArgumentOutOfRangeException
            CORINFO_HELP_THROW_NOT_IMPLEMENTED,             // throw NotImplementedException
            CORINFO_HELP_THROW_PLATFORM_NOT_SUPPORTED,      // throw PlatformNotSupportedException
            CORINFO_HELP_THROW_TYPE_NOT_SUPPORTED,          // throw TypeNotSupportedException

            CORINFO_HELP_JIT_PINVOKE_BEGIN, // Transition to preemptive mode before a P/Invoke, frame is the first argument
            CORINFO_HELP_JIT_PINVOKE_END,   // Transition to cooperative mode after a P/Invoke, frame is the first argument

            CORINFO_HELP_JIT_REVERSE_PINVOKE_ENTER, // Transition to cooperative mode in reverse P/Invoke prolog, frame is the first argument
            CORINFO_HELP_JIT_REVERSE_PINVOKE_EXIT,  // Transition to preemptive mode in reverse P/Invoke epilog, frame is the first argument

            CORINFO_HELP_GVMLOOKUP_FOR_SLOT,        // Resolve a generic virtual method target from this pointer and runtime method handle

            CORINFO_HELP_STACK_PROBE,               // Probes each page of the allocated stack frame

            CORINFO_HELP_PATCHPOINT,                // Notify runtime that code has reached a patchpoint

            CORINFO_HELP_COUNT,
        }

    }
}