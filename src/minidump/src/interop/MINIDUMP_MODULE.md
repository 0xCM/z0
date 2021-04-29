
## MINIDUMP_MODULE

<https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_module>

Contains information for a specific module.

### BaseOfImage

The base address of the module executable image in memory.

### SizeOfImage

The size of the module executable image in memory, in bytes.

### CheckSum

The checksum value of the module executable image.

### TimeDateStamp

The timestamp value of the module executable image, in time_t format.

### ModuleNameRva

An RVA to a MINIDUMP_STRING structure that specifies the name of the module.

### VersionInfo

A VS_FIXEDFILEINFO structure that specifies the version of the module.

### CvRecord

A MINIDUMP_LOCATION_DESCRIPTOR structure that specifies the CodeView record of the module.

### MiscRecord

A MINIDUMP_LOCATION_DESCRIPTOR structure that specifies the miscellaneous record of the module.

### Reserved0

Reserved for future use.

### Reserved1

Reserved for future use.