
using System;
using Singleton;

#region Demo Code
SingleObjectClass singleObject = SingleObjectClass.GetInstance();
singleObject.ShowMessage();

#endregion
Console.WriteLine("Done!");
