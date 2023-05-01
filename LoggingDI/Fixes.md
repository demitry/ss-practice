Issue:
```
System.IO.FileLoadException: 'Could not load file or assembly 'Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)'

{"Could not load file or assembly 'Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)":"Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"}


System.IO.FileLoadException
  HResult=0x80131040
  Message=Could not load file or assembly 'Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)
  Source=mscorlib
  StackTrace:
   at System.Signature.GetSignature(Void* pCorSig, Int32 cCorSig, RuntimeFieldHandleInternal fieldHandle, IRuntimeMethodInfo methodHandle, RuntimeType declaringType)
   at System.Signature..ctor(IRuntimeMethodInfo methodHandle, RuntimeType declaringType)
   at System.Reflection.RuntimeConstructorInfo.GetParametersNoCopy()
   at System.Reflection.RuntimeConstructorInfo.GetParameters()
   at Autofac.Core.Activators.Reflection.ConstructorBinder..ctor(ConstructorInfo constructorInfo)
   at Autofac.Core.Activators.Reflection.ReflectionActivator.ConfigurePipeline(IComponentRegistryServices componentRegistryServices, IResolvePipelineBuilder pipelineBuilder)
   at Autofac.Core.Registration.ComponentRegistration.BuildResolvePipeline(IComponentRegistryServices registryServices, IResolvePipelineBuilder pipelineBuilder)
   at Autofac.Core.Registration.ComponentRegistration.BuildResolvePipeline(IComponentRegistryServices registryServices)
   at Autofac.Core.Registration.ComponentRegistryBuilder.Build()
   at Autofac.ContainerBuilder.Build(ContainerBuildOptions options)
   at ConsoleApp.Program.Main(String[] args) in F:\NEW_JOB_2023\git\ss-practice\LoggingDI\ConsoleApp\Program.cs:line 33

```

Solution:
```
    <Reference Include="Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60, processorArchitecture=MSIL">
      <HintPath>..\packages\Microsoft.Extensions.Logging.Abstractions.7.0.0\lib\net462\Microsoft.Extensions.Logging.Abstractions.dll</HintPath>
    </Reference>
```
	
	Change to 

```	
    <PackageReference Include="Microsoft.Extensions.Logging.Abstractions" Version="7.0.0.0" />
```