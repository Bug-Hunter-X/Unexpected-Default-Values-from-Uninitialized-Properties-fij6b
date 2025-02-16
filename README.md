# Unexpected Default Values from Uninitialized Properties in C#

This example demonstrates a subtle issue in C# where accessing a property before it's explicitly assigned a value can lead to unexpected behavior.

## The Problem

In C#, class properties have default values even if they aren't initialized.  Accessing an uninitialized property will return its default value (0 for integers, false for booleans, null for reference types). This might lead to unexpected behavior if the programmer assumes the absence of a value means null or some exception.