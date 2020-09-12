# Default Segment Selection Rules, Table 3.5, Intel Vol1
----------------------------------------------------------------------------------------------------
| Reference Type      | Register Used | Segment Used                                 | Default Selection Rule                                                                                 |
| Instructions        | CS            | Code Segment                                 | All instruction fetches.                                                                               |
| Stack               | SS            | Stack Segment                                | All stack pushes and pops. Any memory reference which uses the ESP or EBP register as a base register. |
| Local Data          | DS            | Data Segment                                 | All data references, except when relative to stack or string destination.                              |
| Destination Strings | ES            | Data Segment pointed to with the ES register | Destination of string instructions.                                                                    |
