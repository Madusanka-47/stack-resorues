## KEY POINTS
Anonymous Types (ex000001)</br>
Type Constrains (ex000002)</br>
Operator Overloading (ex000003)</br>
Null-Coalescing Operator **<span style="color: lightblue;">??</span>** (ex000004)</br>
Type Parameters & Arguments (ex000005)</br>
Lambda Expressions (ex000006)</br>
Tuples (ex000007)</br>
Nesting Mixed Generic Types (ex000008)</br>
Boxing & Unboxing (ex000009)</br>
Nullable (ex000010)</br>
Multicasting Deligates (ex000011)</br>
Wrapping Deligates (ex000012)</br>
Multiple Scope Capturing (related to: lamda experssions) (ex000013)</br>
Expression Tree (ex000014) </br>
Range Variables (ex000015)</br>
Optional Parameters(ex000016)</br>
Method Group Conversion</br>
Lazy Execution</br>

#### <u>Key words</u>
<span style="color: Turquoise ;">
Generic Arity</br>
Lifted Operators</br>
Closure</br>
Identity Conversion</br>
Autoprops</br>
Projection Initializer</br>
Expression/Statement bodies</br>
Captured Variable</br>
Query Expressions</br>
Transparent Identifier</br>
</br>
</span>

## CODE BLOCKS
| Syntax      | Description |
| :---        |    :----   |
| typeof(List<>);      |List<> without type argument, only possible in typeof syntax      |
| default(int);   | Syntax for assign default value for the relavent type        |
| int? x = new int?();   | Nullable int declaration        |
| Nullable\<T>   | To check non nullable value type        |
| operator   | Syntax for operator overloading        |
| box is int   | To check whether value is int for the boxed value        |
| o as int?   | boxed nullable conversion to int       |
| yield return   | Lazy execution        |
| WinForms::Button   | Namespace alias qualifier        |
| extern alias JsonNet;   | When two types with same name coming from diffrent assemblies         |
| public fixed byte Data[16];   | Fixed sized buffer, can only be access via unsafe Struct         |
| [assembly:InternalsVisibleTo("MyProduct.Test")] </br>signed assembly => [assembly:InternalsVisibleTo ("NodaTime.Test,PublicKey=0024...4669"]   | Used for access internal methods        |
| public fixed byte Data[16];   | Fixed sized buffer, can only be access via unsafe Struct         |
<!-- <p>To be check</p>

Mutation</br>
Implicit & Explicit </br>
Operator Overload => https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading</br>
Property Accessors</br>
State Machine</br>
Unsafe/ Volatile</br>
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile
</br>
COM Component Object Modal</br>
Reflection</br>
Transparent Caching</br>
Reflection</br>
Call Sites </br>
Coveriance/Contravariace/Invariance</br>
</br> -->


### **NOTES**
Operator Overloads</br>
-- Unary: **+ ++ - -- ! ~ true false**</br>
-- Binary:5 **+ - * / % & | ^ << >>**</br>
-- Equality: **== !=**</br>
-- Relational: **< > <= >=**


<!-- ### **TOOLS**
### Ildasm.exe -->