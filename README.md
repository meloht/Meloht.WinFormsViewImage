# Meloht.WinFormsViewImage

WinForms View Image tool

![C#](https://img.shields.io/badge/language-C%23-blue.svg) ![.NET Version](https://img.shields.io/badge/dynamic/xml?url=https://raw.githubusercontent.com/meloht/Meloht.WinFormsViewImage/refs/heads/master/Meloht.WinFormsViewImage/Meloht.WinFormsViewImage.csproj&query=//TargetFrameworks&label=.NET) ![Release](https://img.shields.io/github/v/release/meloht/Meloht.WinFormsViewImage.svg?label=Release&logo=github) [![NuGet](https://img.shields.io/nuget/v/Meloht.WinFormsViewImage.svg?logo=nuget&logoColor=white)](https://www.nuget.org/packages/Meloht.WinFormsViewImage/) [![NuGet](https://img.shields.io/nuget/dt/Meloht.WinFormsViewImage.svg?logo=nuget)](https://www.nuget.org/packages/Meloht.WinFormsViewImage/)


# Usage
```csharp
FormImageViewUtils.Show(this.textBoxImagePath.Text);

byte[] bytes = File.ReadAllBytes(this.textBoxImagePath.Text);
string fileName = Path.GetFileName(this.textBoxImagePath.Text);
FormImageViewUtils.Show(fileName, bytes);

using FileStream fs = new FileStream(this.textBoxImagePath.Text, FileMode.Open, FileAccess.Read);
string fileName = Path.GetFileName(this.textBoxImagePath.Text);
FormImageViewUtils.Show(fileName, fs);
```
<img width="832" height="557" alt="image" src="https://github.com/user-attachments/assets/060acef8-8c04-4d9a-8225-9d2b1df67b65" />
