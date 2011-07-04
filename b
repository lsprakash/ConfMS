 #!/bin/bash
 export PATH=$PATH:.
 tools/Nant/bin/nant.exe -buildfile:./build/master.build  -logfile:b.log $*
