#! "netcoreapp2.1"

#r "../src/IfNotNull/bin/Debug/netstandard2.0/IfNotNull.dll"

using IfNotNull;
using System;

var a =
    "a"
    .IfNotNull(x => x.ToUpper())
    .IfNotNull(x => 100);

Console.WriteLine(a);
