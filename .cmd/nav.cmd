set NavRoot=%ZControl%\nav
echo NavRoot:%NavRoot%

set NavSrc=%NavRoot%\z0
echo NavSrc:%NavSrc%

set NavDst=%ZDev%
echo NavDst:%NavDst%

echo on
mklink /D %NavSrc% %NavDst% 
