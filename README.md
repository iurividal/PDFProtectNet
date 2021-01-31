# PDFProtectNet

Objetivo: Proteger pdf com senha

Tecnologias utlizadas

- C# 8
- .NET CORE
- iText7

Import a DLL SetPasword para o projeto

Inicialize a classe da seguinte maneira

 SetPassword.PdfSetPw pw = new SetPassword.PdfSetPw();
 pw.Set(arquivo, senha);
