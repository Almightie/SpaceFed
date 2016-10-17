# Coding Standards
Coding conventions serve the following purposes:
* They create a consistent look to the code, so that readers can focus on content, not layout
* They enable readers to understand the code more quickly by making assumptions based on previous experience
* They facilitate copying, changing, and maintaining the code
* They demonstrate C# best practices

While the conventions should be adhered, there will always be situations where one has to break with one or more of them. Should you find yourselve in this situation, do not worry! Just leave an in-code comment above the row (or block) with a short description of why you had to do what you did :-)
## 1. Naming Conventions
### 1.1 In General
* Avoid using Linq functionality
* Unless mentioned otherwise in this document, use the [DoFactories C# Coding Standards](http://www.dofactory.com/reference/csharp-coding-standards) as a guideline
* Give preference to using names that describe the variable, method or class the best. Don't use short, meaningless names unless you are using it as an index in a small, easy to read loop:
````C#
for(int i = 0; i < array.Length; i++)
{
	Console.WriteLine(array[i]);
}
````
> `i` is ok here, it's function is obvious

The function of `i` becomes less obvious when we have a lot of nesting going on in the loop and this should be a point at which a variable is renamed to something sensible.

### 1.2 Class Naming
Class names are written using Pascal Case. This is also the case for Interfaces, Delegates, Enumerations & Structs.
Interfaces are prefixed using an 'I'.

```C#
public interface IManager
{
	// Stuff
}
````
Align brackets vertically like the ones in the examble above.
Avoid the usage of partial classes.

### 1.3 Method Naming
Names of methods, public, protected or private, are all written using Pascal Case.

### 1.4 Property Naming
Names of properties are all written using Pascal Case.

### 1.5 Variable Naming
Variables are all names using Camel Case. Member variables are prefixed with `_`.\
Variables are never public.

```C#
public class User
{
	private int _userId;
	private string _userName;

	public User(int userId, string userName)
	{
		_userId = userId;
		_userName = userName;
	}	
}
```

## 2. Layout Conventions
* Write only one statement per line
* Write only one declaration per line
* If continuation lines are not indented automatically, indent them one tab stop 
* Add at least one blank line between method definitions and property definitions
* Use parentheses to make clauses in an expression apparent, as shown in the following code
```C#
if ((val1 > val2) && (val1 > val3))
{
	// Take appropriate action.
}
```


## 3. Commenting Conventions

* Place the comment on a separate line, not at the end of a line of code
* Begin comment text with an uppercase letter
* End comment text with a period
* Do not create formatted blocks of asterisks around comments
* Insert one space between the comment delimiter (//) and the comment text, as shown in the following example

```C#
// The following declaration creates a query. It does not run
// the query.

```

## 4. Type Conventions
When declaring a variable, explicitly declare it's type along. Do not use the now 'popular' inferred type `var`, as in my opinion, this does not increase the readibility of the code at all.
```C#
public void Calculate(int multiPlier)
{
	// Avoid using this.
	var newValue = 5 * multiPlier;

	// Instead, explicitly state the variables' type.
	int newValue = 5 * multiPlier;
}