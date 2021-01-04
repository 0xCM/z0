//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;

    class MetadataInfo
    {
        public const string AssemblyRefTableRowDescription = @"
            The AssemblyRef table has the following columns:
             MajorVersion, MinorVersion, BuildNumber, RevisionNumber (each being 2-byte constants)
             Flags (a 4-byte bitmask of type AssemblyFlags, §23.1.2)
             PublicKeyOrToken (an index into the Blob heap, indicating the public key or token that identifies
            the author of this Assembly)
             Name (an index into the String heap)
             Culture (an index into the String heap)
             HashValue (an index into the Blob heap)
            The table is defined by the .assembly extern directive (§6.3). Its columns are filled using directives
            similar to those of the Assembly table except for the PublicKeyOrToken column, which is defined using the
            .publickeytoken directive. (For an example, see §6.3.)

            1. MajorVersion, MinorVersion, BuildNumber, and RevisionNumber can each have any value
            2. Flags shall have only one bit set, the PublicKey bit (§23.1.2). All other bits shall be zero.
            [ERROR]
            3. PublicKeyOrToken can be null, or non-null (note that the Flags.PublicKey bit specifies
            whether the 'blob' is a full public key, or the short hashed token)
            4. If non-null, then PublicKeyOrToken shall index a valid offset in the Blob heap [ERROR]
            5. Name shall index a non-empty string, in the String heap (there is no limit to its length) [ERROR]
            6. Culture can be null or non-null.
            7. If non-null, it shall index a single string from the list specified (§23.1.3) [ERROR]
            8. HashValue can be null or non-null
            9. If non-null, then HashValue shall index a non-empty 'blob' in the Blob heap [ERROR]
            10. The AssemblyRef table shall contain no duplicates (where duplicate rows are deemd to be those
            having the same MajorVersion, MinorVersion, BuildNumber, RevisionNumber,
            PublicKeyOrToken, Name, and Culture) [WARNING]
            [Note: Name is a simple name (e.g., ―Foo‖, with no drive letter, no path, and no file extension); on POSIX-
            compliant systems Name contains no colon, no forward-slash, no backslash, and no period. end note]";

        public const string ManifestResourceDescription = @"
            The ManifestResource table has the following columns:
             Offset (a 4-byte constant)
             Flags (a 4-byte bitmask of type ManifestResourceAttributes, §23.1.9)
             Name (an index into the String heap)
             Implementation (an index into a File table, a AssemblyRef table, or null; more precisely, an
            Implementation (§24.2.6) coded index)
            The Offset specifies the byte offset within the referenced file at which this resource record begins. The
            Implementation specifies which file holds this resource. The rows in the table result from .mresource
            directives on the Assembly (§6.2.2).
            1. The ManifestResource table can contain zero or more rows
            2. Offset shall be a valid offset into the target file, starting from the Resource entry in the CLI
            header [ERROR]
            3. Flags shall have only those values set that are specified [ERROR]
            4. The VisibilityMask (§23.1.9) subfield of Flags shall be one of Public or Private [ERROR]
            5. Name shall index a non-empty string in the String heap [ERROR]
            6. Implementation can be null or non-null (if null, it means the resource is stored in the current file)
            7. If Implementation is null, then Offset shall be a valid offset in the current file, starting from the
            Resource entry in the CLI header [ERROR]
            8. If Implementation is non-null, then it shall index a valid row in the File or AssemblyRef table
            [ERROR]
            9. There shall be no duplicate rows, based upon Name [ERROR]
            10. If the resource is an index into the File table, Offset shall be zero [ERROR]";

        public const string GenericParamDescription = @"
            The GenericParam table has the following columns:
             Number (the 2-byte index of the generic parameter, numbered left-to-right, from zero)
             Flags (a 2-byte bitmask of type GenericParamAttributes, §23.1.7)
             Owner (an index into the TypeDef or MethodDef table, specifying the Type or Method to which
            this generic parameter applies; more precisely, a TypeOrMethodDef (§24.2.6) coded index)
             Name (a non-null index into the String heap, giving the name for the generic parameter. This is
            purely descriptive and is used only by source language compilers and by Reflection)
            The GenericParam table stores the generic parameters used in generic type definitions and generic method
            definitions. These generic parameters can be constrained (i.e., generic arguments shall extend some class
            and/or implement certain interfaces) or unconstrained. (Such constraints are stored in the
            GenericParamConstraint table.)
            Conceptually, each row in the GenericParam table is owned by one, and only one, row in either the TypeDef or
            MethodDef tables.
            [Example:
            .class Dict`2<([mscorlib]System.IComparable) K, V>
            The generic parameter K of class Dict is constrained to implement System.IComparable .
            .method static void ReverseArray<T>(!!0[] 'array')
            There is no constraint on the generic parameter T of the generic method ReverseArray .
            end example]

             Owner cannot be a non-nested enumeration type; and
             If Owner is a nested enumeration type then Number must be less than or equal to the number of
            generic parameters of the enclosing class. Generic enumeration types serve little purpose and usually only exist to meet CLR Rule 42. These
            additional restrictions limit the genericty of enumeration types while allowing CLS Rule 42 to be met.

            1. GenericParam table can contain zero or more rows
            2. Each row shall have one, and only one, owner row in the TypeDef or MethodDef table (i.e., no
            row sharing) [ERROR]
            3. Every generic type shall own one row in the GenericParam table for each of its generic
            parameters [ERROR]
            4. Every generic method shall own one row in the GenericParam table for each of its generic
            parameters [ERROR]
            Flags:
             Can hold the value Covariant or Contravariant, but only if the owner row corresponds to a
            generic interface, or a generic delegate class. [ERROR]
             Otherwise, shall hold the value None indicating nonvariant (i.e., where the parameter is
            nonvariant or the owner is a non delegate class, a value-type, or a generic method) [ERROR]
            If Flags == Covariant then the corresponding generic parameter can appear in a type definition only as
            [ERROR]:
             The result type of a method
             A generic parameter to an inherited interface
            If Flags == Contravariant then the corresponding generic parameter can appear in a type definition only
            as the argument to a method [ERROR]
            Number shall have a value >= 0 and < the number of generic parameters in owner type or method.
            [ERROR]
            Successive rows of the GenericParam table that are owned by the same method shall be ordered by
            increasing Number value; there shall be no gaps in the Number sequence [ERROR]
            Name shall be non-null and index a string in the String heap [ERROR]
            [Rationale: Otherwise, Reflection output is not fully usable. end rationale]
            There shall be no duplicate rows based upon Owner+Name [ERROR] [Rationale: Otherwise, code
            using Reflection cannot disambiguate the different generic parameters. end rationale]
            There shall be no duplicate rows based upon Owner+Number [ERROR]
            ";

        public const string AssemblyRowDescription = @"
            The Assembly table has the following columns:
             HashAlgId (a 4-byte constant of type AssemblyHashAlgorithm, §23.1.1)
             MajorVersion, MinorVersion, BuildNumber, RevisionNumber (each being 2-byte constants)
             Flags (a 4-byte bitmask of type AssemblyFlags, §23.1.2)
             PublicKey (an index into the Blob heap)
             Name (an index into the String heap)
             Culture (an index into the String heap)
            The Assembly table is defined using the .assembly directive (§6.2); its columns are obtained from the
            respective .hash algorithm, .ver, .publickey, and .culture (§6.2.1). (For an example, see §6.2.)

            1. The Assembly table shall contain zero or one row [ERROR]
            2. HashAlgId shall be one of the specified values [ERROR]
            3. MajorVersion, MinorVersion, BuildNumber, and RevisionNumber can each have any value
            4. Flags shall have only those values set that are specified [ERROR]
            5. PublicKey can be null or non-null
            6. Name shall index a non-empty string in the String heap [ERROR]
            7. The string indexed by Name can be of unlimited length
            8. Culture can be null or non-null
            9. If Culture is non-null, it shall index a single string from the list specified (§23.1.3) [ERROR]
            [Note: Name is a simple name (e.g., ―Foo‖, with no drive letter, no path, and no file extension); on POSIX-
            compliant systems, Name contains no colon, no forward-slash, no backslash, and no period. end note]";

        public const string FileTableDescription = @"
            The File table has the following columns:
             Flags (a 4-byte bitmask of type FileAttributes, §23.1.6)
             Name (an index into the String heap)
             HashValue (an index into the Blob heap)
            The rows of the File table result from .file directives in an Assembly (§6.2.3)

            1. Flags shall have only those values set that are specified (all combinations valid) [ERROR]
            2. Name shall index a non-empty string in the String heap. It shall be in the format
            <filename>.<extension> (e.g., ―foo.dll‖, but not ―c:\utils\foo.dll‖) [ERROR]

            Also, the following values for Name are invalid (since these represent device, rather than file, names):
            S [N] [[C]*] where:
            S ::= con | aux | lpt | prn | null | com (case-blind)
            N ::= a number 0 .. 9
            C ::= $ | :
            [] denotes optional, * denotes Kleene closure, | denotes alternatives [ERROR]
            The CLI also checks dynamically against opening a device, which can be assigned an arbitrary name by
            the user

            3. HashValue shall index a non-empty 'blob' in the Blob heap [ERROR]
            4. There shall be no duplicate rows; that is, rows with the same Name value [ERROR]
            5. If this module contains a row in the Assembly table (that is, if this module ―holds the manifest‖)
            then there shall not be any row in the File table for this module; i.e., no self-reference [ERROR]
            6. If the File table is empty, then this, by definition, is a single-file assembly. In this case, the
            ExportedType table should be empty [WARNING]
        ";

        public const string EventDescription = @"
            22.13 Event : 0x14
            The Event table has the following columns:
             EventFlags (a 2-byte bitmask of type EventAttributes, §23.1.4)
             Name (an index into the String heap)
             EventType (an index into a TypeDef, a TypeRef, or TypeSpec table; more precisely, a
            TypeDefOrRef (§24.2.6) coded index) (This corresponds to the Type of the Event; it is not the
            Type that owns this event.)
            Note that Event information does not directly influence runtime behavior; what counts is the information stored
            for each method that the event comprises.
            The EventMap and Event tables result from putting the .event directive on a class (§18).

            1. The Event table can contain zero or more rows
            2. Each row shall have one, and only one, owner row in the EventMap table [ERROR]
            3. EventFlags shall have only those values set that are specified (all combinations valid) [ERROR]
            4. Name shall index a non-empty string in the String heap [ERROR]";

        public const string EventMapDescription = @"
            The EventMap table has the following columns:
             Parent (an index into the TypeDef table)
             EventList (an index into the Event table). It marks the first of a contiguous run of Events owned
            by this Type. That run continues to the smaller of:
            o the last row of the Event table
            Partition II 137
            o the next run of Events, found by inspecting the EventList of the next row in the
            EventMap table
            Note that EventMap info does not directly influence runtime behavior; what counts is the information stored for
            each method that the event comprises.
            The EventMap and Event tables result from putting the .event directive on a class (§18).

            1. EventMap table can contain zero or more rows
            2. There shall be no duplicate rows, based upon Parent (a given class has only one ‗pointer‘ to the
            start of its event list) [ERROR]
            3. There shall be no duplicate rows, based upon EventList (different classes cannot share rows in the
            Event table) [ERROR]";


        public const string ClassLayoutDescription = @"
                The ClassLayout table is used to define how the fields of a class or value type shall be laid out by the CLI.
            (Normally, the CLI is free to reorder and/or insert gaps between the fields defined for a class or value type.)
            [Rationale: This feature is used to lay out a managed value type in exactly the same way as an unmanaged
            C struct, allowing a managed value type to be handed to unmanaged code, which then accesses the fields
            exactly as if that block of memory had been laid out by unmanaged code. end rationale]
            The information held in the ClassLayout table depends upon the Flags value for {AutoLayout,
            SequentialLayout, ExplicitLayout} in the owner class or value type.
            A type has layout if it is marked SequentialLayout or ExplicitLayout. If any type within an inheritance chain
            has layout, then so shall all its base classes, up to the one that descends immediately from System.ValueType
            (if it exists in the type‘s hierarchy); otherwise, from System.Object

            The ClassLayout table has the following columns:
             PackingSize (a 2-byte constant)
             ClassSize (a 4-byte constant)
             Parent (an index into the TypeDef table)
            The rows of the ClassLayout table are defined by placing .pack and .size directives on the body of the type
            declaration in which this type is declared (§10.2). When either of these directives is omitted, its corresponding
            value is zero. (See §10.7.)
            ClassSize of zero does not mean the class has zero size. It means that no .size directive was specified at
            definition time, in which case, the actual size is calculated from the field types, taking account of packing size
            (default or specified) and natural alignment on the target, runtime platform.

            1. A ClassLayout table can contain zero or more rows
            2. Parent shall index a valid row in the TypeDef table, corresponding to a Class or ValueType (but
            not to an Interface) [ERROR]
            132 Partition II
            3. The Class or ValueType indexed by Parent shall be SequentialLayout or ExplicitLayout
            (§23.1.15). (That is, AutoLayout types shall not own any rows in the ClassLayout table.)
            [ERROR]
            4. If Parent indexes a SequentialLayout type, then:
            o PackingSize shall be one of {0, 1, 2, 4, 8, 16, 32, 64, 128}. (0 means use the default
            pack size for the platform on which the application is running.) [ERROR]
            o If Parent indexes a ValueType, then ClassSize shall be less than 1 MByte (0x100000
            bytes). [ERROR]";

        public const string ImplMapDescription = @"
            The ImplMap table holds information about unmanaged methods that can be reached from managed code,
            using PInvoke dispatch.
            Each row of the ImplMap table associates a row in the MethodDef table (MemberForwarded) with the name of
            a routine (ImportName) in some unmanaged DLL (ImportScope).
            [Note: A typical example would be: associate the managed Method stored in row N of the Method table (so
            MemberForwarded would have the value N) with the routine called ―GetEnvironmentVariable‖ (the string
            indexed by ImportName) in the DLL called ―kernel32‖ (the string in the ModuleRef table indexed by
            ImportScope). The CLI intercepts calls to managed Method number N, and instead forwards them as calls to
            the unmanaged routine called ―GetEnvironmentVariable‖ in ―kernel32.dll‖ (including marshalling any
            arguments, as required)
            The CLI does not support this mechanism to access fields that are exported from a DLL, only methods. end
            note]
            The ImplMap table has the following columns:
             MappingFlags (a 2-byte bitmask of type PInvokeAttributes, §23.1.7)
             MemberForwarded (an index into the Field or MethodDef table; more precisely, a
            MemberForwarded (§24.2.6) coded index). However, it only ever indexes the MethodDef table,
            since Field export is not supported.
             ImportName (an index into the String heap)
             ImportScope (an index into the ModuleRef table)
            A row is entered in the ImplMap table for each parent Method (§15.5) that is defined with a .pinvokeimpl
            interoperation attribute specifying the MappingFlags, ImportName, and ImportScope.

            1. ImplMap can contain zero or more rows
            2. MappingFlags shall have only those values set that are specified [ERROR]
            3. MemberForwarded shall index a valid row in the MethodDef table [ERROR]
            4. The MappingFlags.CharSetMask (§23.1.7) in the row of the MethodDef table indexed by
            MemberForwarded shall have at most one of the following bits set: CharSetAnsi ,
            CharSetUnicode , or CharSetAuto (if none is set, the default is CharSetNotSpec ) [ERROR]

            The MappingFlags.CallConvMask in the row of the Method table indexed by MemberForwarded
            shall have at most one of the following values: CallConvWinapi , CallConvCdecl ,
            CallConvStdcall . It cannot have the value CallConvFastcall or CallConvThiscall . [ERROR]

            ImportName shall index a non-empty string in the String heap [ERROR]
            ImportScope shall index a valid row in the ModuleRef table [ERROR]

            The row indexed in the MethodDef table by MemberForwarded shall have its Flags.PinvokeImpl
            = 1, and Flags.Static = 1 [ERROR]";


        public const string FileRvaDescription = @"
            22.18 FieldRVA : 0x1D
            The FieldRVA table has the following columns:
             RVA (a 4-byte constant)
             Field (an index into Field table)
            Conceptually, each row in the FieldRVA table is an extension to exactly one row in the Field table, and records
            the RVA (Relative Virtual Address) within the image file at which this field‘s initial value is stored.
            A row in the FieldRVA table is created for each static parent field that has specified the optional data
            label §16). The RVA column is the relative virtual address of the data in the PE file (§16.3).
            1. RVA shall be non-zero [ERROR]
            2. RVA shall point into the current module‘s data area (not its metadata area) [ERROR]
            3. Field shall index a valid row in the Field table [ERROR]
            4. Any field with an RVA shall be a ValueType (not a Class or an Interface). Moreover, it shall not
            have any private fields (and likewise for any of its fields that are themselves ValueTypes). (If
            any of these conditions were breached, code could overlay that global static and access its private
            fields.) Moreover, no fields of that ValueType can be Object References (into the GC heap)
            [ERROR]
            5. So long as two RVA-based fields comply with the previous conditions, the ranges of memory
            spanned by the two ValueTypes can overlap, with no further constraints. This is not actually an
            additional rule; it simply clarifies the position with regard to overlapped RVA-based fields";


        public const string MemberRefDescription = @"
            22.25 MemberRef : 0x0A

            The MemberRef table combines two sorts of references, to Methods and to Fields of a class, known as
            ‗MethodRef‘ and ‗FieldRef‘, respectively. The MemberRef table has the following columns:
             Class (an index into the MethodDef, ModuleRef,TypeDef, TypeRef, or TypeSpec tables; more
            precisely, a MemberRefParent (§24.2.6) coded index)
             Name (an index into the String heap)
             Signature (an index into the Blob heap)
            An entry is made into the MemberRef table whenever a reference is made in the CIL code to a method or field
            which is defined in another module or assembly. (Also, an entry is made for a call to a method with a VARARG
            signature, even when it is defined in the same module as the call site.)

            1. Class shall be one of the following: [ERROR]
            a. a TypeRef token, if the class that defines the member is defined in another module. (Note
            that it is unusual, but valid, to use a TypeRef token when the member is defined in this same
            module, in which case, its TypeDef token can be used instead.)
            b. a ModuleRef token, if the member is defined, in another module of the same assembly, as a
            global function or variable.
            c. a MethodDef token, when used to supply a call-site signature for a vararg method that is
            defined in this module. The Name shall match the Name in the corresponding MethodDef
            row. The Signature shall match the Signature in the target method definition [ERROR]
            d. a TypeSpec token, if the member is a member of a generic type
            2. Class shall not be null (as this would indicate an unresolved reference to a global function or
            variable) [ERROR]
            3. Name shall index a non-empty string in the String heap [ERROR]

            4. The Name string shall be a valid CLS identifier [CLS]
            5. Signature shall index a valid field or method signature in the Blob heap. In particular, it shall
            embed exactly one of the following ‗calling conventions‘: [ERROR]
            a. DEFAULT (0x0)
            b. VARARG (0x5)
            c. FIELD (0x6)
            d. GENERIC (0x10)
            The above names are defined in the file inc\CorHdr.h as part of the SDK using the prefix
            IMAGE_CEE_CS_CALLCONV

            6. The MemberRef table shall contain no duplicates, where duplicate rows have the same Class,
            Name, and Signature [WARNING]
            7. Signature shall not have the VARARG (0x5) calling convention [CLS]
            8. There shall be no duplicate rows, where Name fields are compared using CLS conflicting-
            identifier-rules. (In particular, note that the return type and whether parameters are marked
            ELEMENT_TYPE_BYREF (§23.1.16) are ignored in the CLS. For example, .method int32 M() and
            .method float64 M() result in duplicate rows by CLS rules. Similarly, .method void
            N(int32 i) and .method void N(int32& i) also result in duplicate rows by CLS rules.) [CLS]

            Name shall not be of the form _VtblGapSequenceNumber<_CountOfSlots>—such methods are
            dummies, used to pad entries in the vtable that CLI generates for COM interop. Such methods
            cannot be called from managed or unmanaged code [ERROR]

            9. If Class and Name resolve to a field, then that field shall not have a value of CompilerControlled
            (§23.1.5) in its Flags.FieldAccessMask subfield [ERROR]
            10. If Class and Name resolve to a method, then that method shall not have a value of
            CompilerControlled in its Flags.MemberAccessMask (§23.1.10) subfield [ERROR]
            11. The type containing the definition of a MemberRef shall be a TypeSpec representing an
            instantiated type.";

        public const string ConstantRowDescription = @"
            The Constant table is used to store compile-time, constant values for fields, parameters, and properties.
            The Constant table has the following columns:
             Type (a 1-byte constant, followed by a 1-byte padding zero); see §23.1.16 . The encoding of Type
            for the nullref value for FieldInit in ilasm (§16.2) is ELEMENT_TYPE_CLASS with a Value of a 4-
            byte zero. Unlike uses of ELEMENT_TYPE_CLASS in signatures, this one is not followed by a type
            token.
             Parent (an index into the Param, Field, or Property table; more precisely, a HasConstant
            (§24.2.6) coded index)
             Value (an index into the Blob heap)
            Note that Constant information does not directly influence runtime behavior, although it is visible via
            Reflection (and hence can be used to implement functionality such as that provided by
            System.Enum.ToString ). Compilers inspect this information, at compile time, when importing metadata, but
            the value of the constant itself, if used, becomes embedded into the CIL stream the compiler emits. There are
            no CIL instructions to access the Constant table at runtime.
            A row in the Constant table for a parent is created whenever a compile-time value is specified for that parent.
            (For an example, see §16.2. )

            1. Type shall be exactly one of: ELEMENT_TYPE_BOOLEAN , ELEMENT_TYPE_CHAR , ELEMENT_TYPE_I1 ,
            ELEMENT_TYPE_U1 , ELEMENT_TYPE_I2 , ELEMENT_TYPE_U2 , ELEMENT_TYPE_I4 , ELEMENT_TYPE_U4 ,
            ELEMENT_TYPE_I8 , ELEMENT_TYPE_U8 , ELEMENT_TYPE_R4 , ELEMENT_TYPE_R8 , or
            ELEMENT_TYPE_STRING ; or ELEMENT_TYPE_CLASS with a Value of zero (§23.1.16) [ERROR]
            2. Type shall not be any of: ELEMENT_TYPE_I1 , ELEMENT_TYPE_U2 , ELEMENT_TYPE_U4 , or
            ELEMENT_TYPE_U8 (§23.1.16) [CLS]
            3. Parent shall index a valid row in the Field, Property, or Param table. [ERROR]
            4. There shall be no duplicate rows, based upon Parent [ERROR]
            5. Type shall match exactly the declared type of the Param, Field, or Property identified by Parent
            (in the case where the parent is an enum, it shall match exactly the underlying type of that enum).
            [CLS]";

        public const string CustomAttributeDescription = @"
            The CustomAttribute table has the following columns:
             Parent (an index into any metadata table, except the CustomAttribute table itself; more precisely,
            a HasCustomAttribute (§24.2.6) coded index)
             Type (an index into the MethodDef or MemberRef table; more precisely, a CustomAttributeType
            (§24.2.6) coded index)
             Value (an index into the Blob heap)
            The CustomAttribute table stores data that can be used to instantiate a Custom Attribute (more precisely, an
            object of the specified Custom Attribute class) at runtime. The column called Type is slightly misleading—it
            actually indexes a constructor method—the owner of that constructor method is the Type of the Custom
            Attribute.
            A row in the CustomAttribute table for a parent is created by the .custom attribute, which gives the value of
            the Type column and optionally that of the Value column (§21).

            All binary values are stored in little-endian format (except for PackedLen items, which are used only as a count
            for the number of bytes to follow in a UTF8 string).
            1. No CustomAttribute is required; that is, Value is permitted to be null.
            2. Parent can be an index into any metadata table, except the CustomAttribute table itself [ERROR]
            3. Type shall index a valid row in the Method or MemberRef table. That row shall be a constructor
            method (for the class of which this information forms an instance) [ERROR]
            4. Value can be null or non-null.
            5. If Value is non-null, it shall index a 'blob' in the Blob heap [ERROR]
            6. The following rules apply to the overall structure of the Value 'blob' (§23.3):
            o Prolog shall be 0x0001 [ERROR]
            o There shall be as many occurrences of FixedArg as are declared in the Constructor
            method [ERROR]
            134 Partition II
            o NumNamed can be zero or more
            o There shall be exactly NumNamed occurrences of NamedArg [ERROR]
            o Each NamedArg shall be accessible by the caller [ERROR]
            o If NumNamed = 0 then there shall be no further items in the CustomAttrib [ERROR]
            7. The following rules apply to the structure of FixedArg (§23.3):
            o If this item is not for a vector (a single-dimension array with lower bound of 0), then
            there shall be exactly one Elem [ERROR]
            o If this item is for a vector, then:
            o NumElem shall be 1 or more [ERROR]
            o This shall be followed by NumElem occurrences of Elem [ERROR]
            8. The following rules apply to the structure of Elem (§23.3):
            o If this is a simple type or an enum (see §23.3 for how this is defined), then Elem
            consists simply of its value [ERROR]
            o If this is a string or a Type, then Elem consists of a SerString – PackedLen count of
            bytes, followed by the UTF8 characters [ERROR]
            o If this is a boxed simple value type ( bool , char , float32 , float64 , int8 , int16 ,
            int32 , int64 , unsigned int8 , unsigned int16 , unsigned int32 , or unsigned
            int64 ), then Elem consists of the corresponding type denoter ( ELEMENT_TYPE_BOOLEAN ,
            ELEMENT_TYPE_CHAR , ELEMENT_TYPE_I1 , ELEMENT_TYPE_U1 , ELEMENT_TYPE_I2 ,
            ELEMENT_TYPE_U2 , ELEMENT_TYPE_I4 , ELEMENT_TYPE_U4 , ELEMENT_TYPE_I8 ,
            ELEMENT_TYPE_U8 , ELEMENT_TYPE_R4 , or ELEMENT_TYPE_R8 ), followed by its value.
            [ERROR]
            9. The following rules apply to the structure of NamedArg (§23.3):
            o The single byte FIELD (0x53) or PROPERTY (0x54) [ERROR]
            o The type of the Field or Property is one of ELEMENT_TYPE_BOOLEAN ,
            ELEMENT_TYPE_CHAR , ELEMENT_TYPE_I1 , ELEMENT_TYPE_U1 , ELEMENT_TYPE_I2 ,
            ELEMENT_TYPE_U2 , ELEMENT_TYPE_I4 , ELEMENT_TYPE_U4 , ELEMENT_TYPE_I8 ,
            ELEMENT_TYPE_U8 , ELEMENT_TYPE_R4 , ELEMENT_TYPE_R8 , ELEMENT_TYPE_STRING , or the
            constant 0x50 (for an argument of type System.Type ) [ERROR]
            o The name of the Field or Property, respectively with the previous item, as a SerString
            – PackedLen count of bytes, followed by the UTF8 characters of the name [ERROR]
            o A FixedArg (see above) [ERROR]        ";

        public const string DeclSecurityDescription = @"
            Security attributes, which derive from System.Security.Permissions.SecurityAttribute (see Partition IV),
            can be attached to a TypeDef, a Method, or an Assembly. All constructors of this class shall take a
            System.Security.Permissions.SecurityAction value as their first parameter, describing what should be
            done with the permission on the type, method or assembly to which it is attached. Code access security
            attributes, which derive from System.Security.Permissions. CodeAccessSecurityAttribute , can have any
            of the security actions.
            These different security actions are encoded in the DeclSecurity table as a 2-byte enum (see below). All
            security custom attributes for a given security action on a method, type, or assembly shall be gathered together,
            and one System.Security.PermissionSet instance shall be created, stored in the Blob heap, and referenced
            from the DeclSecurity table.

            [Note: The general flow from a compiler‘s point of view is as follows. The user specifies a custom attribute
            through some language-specific syntax that encodes a call to the attribute‘s constructor. If the attribute‘s type is
            derived (directly or indirectly) from System.Security.Permissions.SecurityAttribute then it is a security
            custom attribute and requires special treatment, as follows (other custom attributes are handled by simply
            recording the constructor in the metadata as described in §22.10). The attribute object is constructed, and
            provides a method ( CreatePermission ) to convert it into a security permission object (an object derived from
            System.Security.Permission ). All the permission objects attached to a given metadata item with the same
            security action are combined together into a System.Security.PermissionSet . This permission set is
            converted into a form that is ready to be stored in XML using its ToXML method to create a
            System.Security.SecurityElement . Finally, the XML that is required for the metadata is created using the
            ToString method on the security element. end note]
            The DeclSecurity table has the following columns:
             Action (a 2-byte value)
             Parent (an index into the TypeDef, MethodDef, or Assembly table; more precisely, a
            HasDeclSecurity (§24.2.6) coded index)
             PermissionSet (an index into the Blob heap)
            Action is a 2-byte representation of Security Actions (see System.Security.SecurityAction in Partition IV).
            The values 0–0xFF are reserved for future standards use. Values 0x20–0x7F and 0x100–0x07FF are for uses
            where the action can be ignored if it is not understood or supported. Values 0x80–0xFF and 0x0800–0xFFFF
            are for uses where the action shall be implemented for secure operation; in implementations where the action is
            not available, no access to the assembly, type, or method shall be permitted.

            --Begin Table
            Security Action | Note | Explanation of behavior | Valid Scope
            Assert 1 Without further checks, satisfy Demand for the
            specified permission.
            Method, Type
            Demand 1 Check that all callers in the call chain have been
            granted specified permission, throw
            SecurityException (see Partition IV) on failure.
            Method, Type
            Deny 1 Without further checks refuse Demand for the
            specified permission.
            Method, Type
            InheritanceDemand 1 The specified permission shall be granted in order
            to inherit from class or override virtual method.
            Method, Type
            LinkDemand 1 Check that the immediate caller has been granted
            the specified permission; throw
            SecurityException (see Partition IV) on failure.
            Method, Type
            NonCasDemand 2 Check that the current assembly has been granted
            the specified permission; throw
            SecurityException (see Partition IV) otherwise.
            Method, Type
            NonCasLinkDemand 2 Check that the immediate caller has been granted
            the specified permission; throw
            SecurityException (see Partition IV) otherwise.
            Method, Type
            PrejitGrant Reserved for implementation-specific use. Assembly
            PermitOnly 1 Without further checks, refuse Demand for all
            permissions other than those specified.
            Method, Type
            RequestMinimum Specify the minimum permissions required to run. Assembly
            RequestOptional Specify the optional permissions to grant. Assembly
            RequestRefuse Specify the permissions not to be granted. Assembly
            --End Table

            Note 1: The specified attribute shall derive from System.Security.Permissions.CodeAccess-
            SecurityAttribute
            Note 2: The attribute shall derive from System.Security.Permissions.SecurityAttribute , but shall not
            derive from System.Security.Permissions.CodeAccessSecurityAttribute
            Parent is a metadata token that identifies the Method, Type, or Assembly on which security custom attributes
            encoded in PermissionSet was defined.
            PermissionSet is a 'blob' having the following format:
             A byte containing a period (.).
             A compressed int32 containing the number of attributes encoded in the blob.
             An array of attributes each containing the following:
            o A String, which is the fully-qualified type name of the attribute. (Strings are encoded
            as a compressed int to indicate the size followed by an array of UTF8 characters.)
            o A set of properties, encoded as the named arguments to a custom attribute would be (as
            in §23.3, beginning with NumNamed).
            The permission set contains the permissions that were requested with an Action on a specific Method, Type, or
            Assembly (see Parent). In other words, the blob will contain an encoding of all the attributes on the Parent with
            that particular Action.
            [Note: The first edition of this standard specified an XML encoding of a permission set. Implementations
            should continue supporting this encoding for backward compatibility. end note]
            The rows of the DeclSecurity table are filled by attaching a .permission or .permissionset directive
            that specifies the Action and PermissionSet on a parent assembly (§6.6) or parent type or method (§10.2).

            1. Action shall have only those values set that are specified [ERROR]
            2. Parent shall be one of TypeDef, MethodDef, or Assembly. That is, it shall index a valid row in
            the TypeDef table, the MethodDef table, or the Assembly table. [ERROR]
            3. If Parent indexes a row in the TypeDef table, that row should not define an Interface. The
            security system ignores any such parent; compilers should not emit such permissions sets.
            [WARNING]
            4. If Parent indexes a TypeDef, then its TypeDef.Flags.HasSecurity bit shall be set [ERROR]
            5. If Parent indexes a MethodDef, then its MethodDef.Flags.HasSecurity bit shall be set [ERROR]
            6. PermissionSet shall index a 'blob' in the Blob heap [ERROR]
            7. The format of the 'blob' indexed by PermissionSet shall represent a valid, encoded CLI object
            graph. (The encoded form of all standardized permissions is specified in Partition IV.) [ERROR]";

        public const string FieldLayoutRowDescription = @"
            The FieldLayout table has the following columns:
             Offset (a 4-byte constant)
             Field (an index into the Field table)
            Note that each Field in any Type is defined by its Signature. When a Type instance (i.e., an object) is laid out
            by the CLI, each Field is one of four kinds:
             Scalar: for any member of built-in type, such as int32 . The size of the field is given by the size
            of that intrinsic, which varies between 1 and 8 bytes
             ObjectRef: for ELEMENT_TYPE_CLASS , ELEMENT_TYPE_STRING , ELEMENT_TYPE_OBJECT ,
            ELEMENT_TYPE_ARRAY , ELEMENT_TYPE_SZARRAY
             Pointer: for ELEMENT_TYPE_PTR , ELEMENT_TYPE_FNPTR
             ValueType: for ELEMENT_TYPE_VALUETYPE . The instance of that ValueType is actually laid out in
            this object, so the size of the field is the size of that ValueType
            Note that metadata specifying explicit structure layout can be valid for use on one platform but not on another,
            since some of the rules specified here are dependent on platform-specific alignment rules.
            A row in the FieldLayout table is created if the .field directive for the parent field has specified a field
            offset (§16).

            1. A FieldLayout table can contain zero or more or rows
            2. The Type whose Fields are described by each row of the FieldLayout table shall have
            Flags.ExplicitLayout (§23.1.15) set [ERROR]
            3. Offset shall be zero or more [ERROR]
            4. Field shall index a valid row in the Field table [ERROR]
            5. Flags.Static for the row in the Field table indexed by Field shall be non-static (i.e., zero 0)
            [ERROR]
            6. Among the rows owned by a given Type there shall be no duplicates, based upon Field. That is, a
            given Field of a Type cannot be given two offsets. [ERROR]
            7. Each Field of kind ObjectRef shall be naturally aligned within the Type [ERROR]
            8. Among the rows owned by a given Type it is perfectly valid for several rows to have the same
            value of Offset. ObjectRef and a valuetype cannot have the same offset [ERROR]
            9. Every Field of an ExplicitLayout Type shall be given an offset; that is, it shall have a row in the
            FieldLayout table [ERROR]";

        public const string ExportedTypeRowDescription = @"
            22.14 ExportedType : 0x27
            The ExportedType table holds a row for each type:
            a. Defined within other modules of this Assembly; that is exported out of this Assembly. In essence, it
            stores TypeDef row numbers of all types that are marked public in other modules that this Assembly
            comprises.
            The actual target row in a TypeDef table is given by the combination of TypeDefId (in effect, row
            number) and Implementation (in effect, the module that holds the target TypeDef table). Note that this
            is the only occurrence in metadata of foreign tokens; that is, token values that have a meaning in
            another module. (A regular token value is an index into a table in the current module); OR
            b. Originally defined in this Assembly but now moved to another Assembly. Flags must have
            IsTypeForwarder set and Implementation is an AssemblyRef indicating the Assembly the type may
            now be found in.
            The full name of the type need not be stored directly. Instead, it can be split into two parts at any included ―.‖
            (although typically this is done at the last ―.‖ in the full name). The part preceding the ―.‖ is stored as the
            TypeNamespace and that following the ―.‖ is stored as the TypeName. If there is no ―.‖ in the full name, then
            the TypeNamespace shall be the index of the empty string.
            The ExportedType table has the following columns:
             Flags (a 4-byte bitmask of type TypeAttributes, §23.1.15)
             TypeDefId (a 4-byte index into a TypeDef table of another module in this Assembly). This
            column is used as a hint only. If the entry in the target TypeDef table matches the TypeName and
            TypeNamespace entries in this table, resolution has succeeded. But if there is a mismatch, the
            CLI shall fall back to a search of the target TypeDef table. Ignored and should be zero if Flags
            has IsTypeForwarder set.
             TypeName (an index into the String heap)
             TypeNamespace (an index into the String heap)
             Implementation. This is an index (more precisely, an Implementation (§24.2.6) coded index) into
            either of the following tables:
            o File table, where that entry says which module in the current assembly holds the
            TypeDef
            o ExportedType table, where that entry is the enclosing Type of the current nested Type
            o AssemblyRef table, where that entry says in which assembly the type may now be
            found (Flags must have the IsTypeForwarder flag set).
            The rows in the ExportedType table are the result of the .class extern directive (§6.7).

            The term ―FullName‖ refers to the string created as follows: if the TypeNamespace is null, then use the
            TypeName, otherwise use the concatenation of Typenamespace, ― . ‖, and TypeName.
            1. The ExportedType table can contain zero or more rows
            2. There shall be no entries in the ExportedType table for Types that are defined in the current
            module—just for Types defined in other modules within the Assembly [ERROR]
            3. Flags shall have only those values set that are specified [ERROR]
            4. If Implementation indexes the File table, then Flags.VisibilityMask shall be public (§23.1.15)
            [ERROR]
            5. If Implementation indexes the ExportedType table, then Flags.VisibilityMask shall be
            NestedPublic (§23.1.15) [ERROR]
            6. If non-null, TypeDefId should index a valid row in a TypeDef table in a module somewhere within
            this Assembly (but not this module), and the row so indexed should have its Flags.Public = 1
            (§23.1.15) [WARNING]
            7. TypeName shall index a non-empty string in the String heap [ERROR]
            8. TypeNamespace can be null, or non-null
            9. If TypeNamespace is non-null, then it shall index a non-empty string in the String heap [ERROR]
            10. FullName shall be a valid CLS identifier [CLS]
            11. If this is a nested Type, then TypeNamespace should be null, and TypeName should represent the
            unmangled, simple name of the nested Type [ERROR]
            12. Implementation shall be a valid index into either of the following: [ERROR]
            o the File table; that file shall hold a definition of the target Type in its TypeDef table
            o a different row in the current ExportedType table—this identifies the enclosing Type of
            the current, nested Type
            13. FullName shall match exactly the corresponding FullName for the row in the TypeDef table
            indexed by TypeDefId [ERROR]
            14. Ignoring nested Types, there shall be no duplicate rows, based upon FullName [ERROR]
            15. For nested Types, there shall be no duplicate rows, based upon TypeName and enclosing Type
            [ERROR]
            16. The complete list of Types exported from the current Assembly is given as the catenation of the
            ExportedType table with all public Types in the current TypeDef table, where ―public‖ means a
            Flags.VisibilityMask of either Public or NestedPublic. There shall be no duplicate rows, in this
            concatenated table, based upon FullName (add Enclosing Type into the duplicates check if this is
            a nested Type) [ERROR]";

        public const string InterfaceImplDescription = @"
            The InterfaceImpl table has the following columns:
             Class (an index into the TypeDef table)
             Interface (an index into the TypeDef, TypeRef, or TypeSpec table; more precisely, a TypeDefOrRef
            (§24.2.6) coded index)
            The InterfaceImpl table records the interfaces a type implements explicitly. Conceptually, each row in the
            InterfaceImpl table indicates that Class implements Interface.

            1. The InterfaceImpl table can contain zero or more rows
            2. Class shall be non-null [ERROR]
            3. If Class is non-null, then:
            a. Class shall index a valid row in the TypeDef table [ERROR]
            b. Interface shall index a valid row in the TypeDef or TypeRef table [ERROR]
            c. The row in the TypeDef, TypeRef, or TypeSpec table indexed by Interface shall be an
            interface (Flags.Interface = 1), not a Class or ValueType [ERROR]
            4. There should be no duplicates in the InterfaceImpl table, based upon non-null Class and Interface
            values [WARNING]
            5. There can be many rows with the same value for Class (since a class can implement many
            interfaces)
            6. There can be many rows with the same value for Interface (since many classes can implement the
            same interface)";

        public const string FieldDefRowDescription = @"
            The Field table has the following columns:
             Flags (a 2-byte bitmask of type FieldAttributes, §23.1.5)
             Name (an index into the String heap)
             Signature (an index into the Blob heap)
            Conceptually, each row in the Field table is owned by one, and only one, row in the TypeDef table. However,
            the owner of any row in the Field table is not stored anywhere in the Field table itself. There is merely a
            ‗forward-pointer‘ from each row in the TypeDef table (the FieldList column).
            Each row in the Field table results from a top-level .field directive (§5.10), or a .field directive inside a
            Type (§10.2). (For an example, see §14.5.)
            1. The Field table can contain zero or more rows
            2. Each row shall have one, and only one, owner row in the TypeDef table [ERROR]
            3. The owner row in the TypeDef table shall not be an Interface [CLS]
            4. Flags shall have only those values set that are specified [ERROR]
            5. The FieldAccessMask subfield of Flags shall contain precisely one of CompilerControlled ,
            Private , FamANDAssem , Assembly , Family , FamORAssem , or Public (§23.1.5) [ERROR]
            6. Flags can set either or neither of Literal or InitOnly , but not both (§23.1.5) [ERROR]
            7. If Flags.Literal = 1 then Flags.Static shall also be 1 (§23.1.5) [ERROR]
            8. If Flags.RTSpecialName = 1, then Flags.SpecialName shall also be 1 (§23.1.5) [ERROR]
            9. If Flags.HasFieldMarshal = 1, then this row shall ‗own‘ exactly one row in the FieldMarshal
            table (§23.1.5) [ERROR]
            10. If Flags.HasDefault = 1, then this row shall ‗own‘ exactly one row in the Constant table
            (§23.1.5) [ERROR]
            11. If Flags.HasFieldRVA = 1, then this row shall ‗own‘ exactly one row in the Field’s RVA table
            (§23.1.5) [ERROR]
            12. Name shall index a non-empty string in the String heap [ERROR]
            13. The Name string shall be a valid CLS identifier [CLS]
            14. Signature shall index a valid field signature in the Blob heap [ERROR]
            15. If Flags.CompilerControlled = 1 (§23.1.5), then this row is ignored completely in duplicate
            checking.
            16. If the owner of this field is the internally-generated type called <Module> , it denotes that this field
            is defined at module scope (commonly called a global variable). In this case:
            o Flags.Static shall be 1 [ERROR]
            o Flags.MemberAccessMask subfield shall be one of Public , CompilerControlled , or
            Private (§23.1.5) [ERROR]
            o module-scope fields are not allowed [CLS]
            17. There shall be no duplicate rows in the Field table, based upon owner+Name+Signature (where
            owner is the owning row in the TypeDef table, as described above) (Note however that if
            Flags.CompilerControlled = 1, then this row is completely excluded from duplicate checking)
            [ERROR]
            18. There shall be no duplicate rows in the Field table, based upon owner+Name, where Name fields
            are compared using CLS conflicting-identifier-rules. [CLS]
            19. If this is a field of an Enum then:
            a. owner row in TypeDef table shall derive directly from System.Enum [ERROR]
            b. the owner row in TypeDef table shall have no other instance fields [CLS]
            c. its Signature shall be one of ELEMENT_TYPE_U1 , ELEMENT_TYPE_I2 , ELEMENT_TYPE_I4 , or
            ELEMENT_TYPE_I8 (§23.1.16 ): [CLS]
            20. its Signature shall be an integral type. [ERROR]";

    }
}