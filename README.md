## Table of contents
- [Overview](#overview)
  - [Requirements and options](#Requirements-and-options)
  - [Screenshot](#screenshot)
  - [Links](#links)
- [My process](#my-process)
  - [Built with](#built-with)
  - [Code Highlight](#code-highlight)
  - [Continued development](#continued-development)
  - [Useful resources](#useful-resources)
- [Author](#author)

## Overview

### Requirements and options

User should be able to:

- 

### Screenshot

![](./screenshot.jpg)


### Links

- Github Repository: [Add solution URL here](https://github.com/SteveNoyes/siAfilado)
- Github Live Site: [Add live site URL here](https://github.com/SteveNoyes/siAfilado)

## My process

### Built with

- C# 
- Bash 
- [fCC Foundational C# with Microsoft](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/) - An introduction to C# programming, covering its core concepts, syntax, and practical application in software development.
- [.NET Development with VS Code](https://www.linkedin.com/learning/visual-studio-code-for-dot-net-developers/using-visual-studio-with-dot-net?resume=false&u=2225393) - Installation and configuration of .NET SDK and Visual Studio Code and .NET development plugins. Project creation, running and debugging applications, and unit testing.

### Code Highlight

```cs
class IthinkThisCanBeCalledAnything {
  // main method
  static void Main(string[] args)
  {

    string first = "Lorem";
    string last = "Ipsum";

    // string concatenation
    string name = first + " " + last;
    Console.WriteLine(name); // => Lorem Ipsum

    // sting interpolation
    string nameInterpolated = $"{first} {last}";
    Console.WriteLine(nameInterpolated);
  }
}
```

```bash
# use command ./build.sh to use this file in cli 
# add more commands to create an auto build command 
dotnet build
```

### Continued development

- build the command line   

### Useful resources

- [The Markdown Guide](https://www.markdownguide.org/)  - If you want more help with writing markdown, we'd recommend checking out The Markdown Guide to learn more.

## Author

- Website - [Steven Matthew Noyes](https://stevenmnoyes.com)
- LinkedIn - [@steven-noyes/](https://www.linkedin.com/in/steven-noyes/)