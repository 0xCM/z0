// https://docs.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/specifying-fully-qualified-type-names
grammar cli_typename;

IDENTIFIER : '';

NOTOKEN : '';

AssemblyPropertyName : '';

AssemblyPropertyValue : '';

TypeSpec
	: ReferenceTypeSpec
	| SimpleTypeSpec
	;

ReferenceTypeSpec
	: SimpleTypeSpec '&'
	;

SimpleTypeSpec
	: PointerTypeSpec
	| GenericTypeSpec
	| TypeName
	;

GenericTypeSpec : SimpleTypeSpec '`' Number;

PointerTypeSpec : SimpleTypeSpec '*'
	;

ArrayTypeSpec
    : SimpleTypeSpec '[ReflectionDimension]'
    | SimpleTypeSpec '[ReflectionEmitDimension]'
	;

ReflectionDimension : '*'
    | ReflectionDimension ',' ReflectionDimension
	| NOTOKEN
	;

ReflectionEmitDimension
	: '*'
	| Number '..' Number
	| Number '…'
	| ReflectionDimension ',' ReflectionDimension
	| NOTOKEN
	;

Number
	: [0-9]+
	;

TypeName
	: NamespaceTypeName
	| NamespaceTypeName ',' AssemblyNameSpec
	;

NamespaceTypeName
	: NestedTypeName
	| NamespaceSpec '.' NestedTypeName
	;

NestedTypeName
	: IDENTIFIER
	| NestedTypeName '+' IDENTIFIER
	;

NamespaceSpec
	: IDENTIFIER
	| NamespaceSpec '.' IDENTIFIER
	;

AssemblyNameSpec
	: IDENTIFIER
	| IDENTIFIER ',' AssemblyProperties
	;

AssemblyProperties
	: AssemblyProperty
	| AssemblyProperties ',' AssemblyProperty
	;

AssemblyProperty
	: AssemblyPropertyName '=' AssemblyPropertyValue
	;