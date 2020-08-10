set part_id=konst
set input=part sys konst
z0 %input% > %ZLogs%\etl\control_%part_id%.csv

set part_id=math
z0 %part_id% > %ZLogs%\etl\control_%part_id%.csv

set part_id=asm
z0 %part_id% > %ZLogs%\etl\control_%part_id%.csv

set part_id=gvec
z0 %part_id% > %ZLogs%\etl\control_%part_id%.csv
