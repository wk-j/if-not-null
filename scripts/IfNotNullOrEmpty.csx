#! "netcoreapp2.1"
#r "../src/IfNotNull/bin/Debug/netstandard2.0/IfNotNull.dll"

using IfNotNull;


var rs = "xxx".IfNotNullOrEmpty(str => {
    return str.ToUpper();
});

Console.WriteLine(rs);

string nulll = null;
var rs2 = nulll.IfNotNullOrEmpty(str => {
    return str.ToUpper();
});

Console.WriteLine(rs2);


