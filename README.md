# <img src="https://cloud.githubusercontent.com/assets/378023/15172388/b2b81950-1790-11e6-9a7c-ccc39912bb3a.png" width="60px" align="center" alt="Electron.NET API Demos icon"> Electron.NET API 演示（中文版）  
  > 此项目同步自 [ElectronNET](https://github.com/ElectronNET) 的 [electron.net-api-demos](https://github.com/ElectronNET/electron.net-api-demos) 项目. 不定期更新.
  >
  这是一个桌面应用程序，通过交互和示例代码演示了[Electron.NET](https://github.com/ElectronNET/Electron.NET) API的核心功能.
  当然, 它也是由 Electron 构建的. 此应用程序适用于 Windows, macOS 和 Linux 操作系统.
  
使用此应用程序查看如何使用Electron.NET，并使用源代码学习如何创建基本的Electron.NET应用程序。

![Image of Electron.NET API Demos App](https://cloud.githubusercontent.com/assets/378023/15016148/ae06cc80-124a-11e6-80dd-076d83e492f6.png)

---  
  
## 开始使用
1.您需要在计算机上安装[Node.js（v.12.x）](https://nodejs.org)和[.NET Core SDK (v.3.1)](https://www.microsoft.com/NET/download/Core)才能启动或构建此应用程序。

2.更改npm配置信息：使用以下命令将npm配置为国内镜像，这样可以提升依赖包的下载速度
```
npm config set registry https://registry.npm.taobao.org/
npm config set metrics-registry https://registry.npm.taobao.org/
npm config set electron_mirror https://npm.taobao.org/mirrors/electron/
npm config set sass_binary_site https://npm.taobao.org/mirrors/node-sass/
```
3.克隆仓库，启动程序
```bash
$ dotnet tool install --global ElectronNET.CLI  //全局安装ElectronNET.CLI，安装一次即可
$ git clone https://github.com/2270969436/electron.net-api-demos-Zh_CN
$ cd electron.net-api-demos-Zh_CN
$ electronize start
```

## 👩‍🏫 在新项目中使用Electron.NET

请在您的ASP.NET Core应用程序中安装[ElectronNET.API NuGet package]
````
PM> Install-Package ElectronNET.API
````
### Program.cs

使用“UseElectron”WebHostBuilder扩展名启动Electron.NET。

```csharp
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseElectron(args);
                    webBuilder.UseStartup<Startup>();
                });
```

### Startup.cs

在Startup.cs文件中配置Electron的启动窗口: 

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    ...

    // 在这里打开Electron窗口
    Task.Run(async () => await Electron.WindowManager.CreateWindowAsync());
}
```

## 🚀 启动应用程序

要启动应用程序，请确保已将“[ElectronNET.CLI](https://www.nuget.org/packages/ElectronNET.CLI/)”包作为全局工具安装：

```
dotnet tool install ElectronNET.CLI -g
```

第一次使用，您需要将Electron.NET项目初始化。在ASP.NET Core文件夹中键入以下命令:

```
electronize init
```

* 现在，一个electronnet.manifest.json应该出现在您的ASP.NET Core项目中
* 现在运行以下命令:

```
electronize start
```

### 注意
> 第一次启动Electron会比较慢，后续启动会比第一次快很多。

## 🔭 使用文件监视程序开发Electron.NET应用

文件监视程序包含在Electron.NET版本 8.31.1 中。例如，文件更改可以触发编译、测试执行或部署。Electron.NET窗口将自动刷新，新的代码更改将更快地显示。需要以下Electron.NET CLI 命令:

```
electronize start /watch
```

## 🐞 调试

使用 Electron.NET CLI 命令启动Electron.NET应用程序。在 Visual Studio 中附加到正在运行的应用程序实例。转到调试菜单，然后单击"附加到进程..."。按右侧的项目名称排序，并在列表中选择它.


## 📔Electron API 的使用

请查看示例应用程序的源代码：[Electron.NET API Demos (中文版)](https://github.com/2270969436/electron.net-api-demos-Zh_CN)  

  
## ⛏ 程序打包

这里您还需要Electron.NET CLI。在ASP.NET Core文件夹中键入以下命令:

```
electronize build /target win
```

还有其他可用的平台:

```
electronize build /target win
electronize build /target osx
electronize build /target linux
```

这三个"默认"目标将为这些平台生成 x64 包。.

对于某些 NuGet 包或某些方案，您可能需要构建纯 x86 应用程序。为了支持这些内容，您可以定义所需的[.NET Core runtime](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)，[electron platform](https://github.com/electron-userland/electron-packager/blob/master/docs/api.md#platform)和[electron architecture](https://github.com/electron-userland/electron-packager/blob/master/docs/api.md#arch)，如下所示：

```
electronize build /target custom win7-x86;win32 /electron-arch ia32 
```

最终结果应该是/bin/桌面文件夹下的电子应用程序。

### 注意
> macOS 生成无法在 Windows 计算机上创建，因为它们需要 Windows 上不支持的符号链接（基于此[Electron issue](https://github.com/electron-userland/electron-packager/issues/71)）。macOS 构建可以在 Linux 或 macOS 计算机上生成。

### 节点集成
Electron.NET需要启用节点集成才能启用 IPC 才能运行。如果您不使用 IPC 功能，您可以禁用节点集成，如下所示:

```csharp
WebPreferences wp = new WebPreferences();
wp.NodeIntegration = false;
BrowserWindowOptions browserWindowOptions = new BrowserWindowOptions
{
    WebPreferences = wp
}

```

## Electron相关
>ELectron.NET 源码
>* GIthub仓库：[ELectron.NET](https://github.com/ElectronNET/Electron.NET)

> Electron.NET API 示例
>* 英文版：[Electron.NET（Github）](https://github.com/ElectronNET/electron.net-api-demos)
>* 中文版：[Electron.NET API示例（Github）](https://github.com/2270969436/electron.net-api-demos-Zh_CN)
>* 中文版：[Electron.NET API示例（Gitee）](https://gitee.com/shiyulanxuan/electron.net-api-demos-Zh_CN)

> Electron API 示例
>* 英文版：[Electron（Github）](https://github.com/electron/electron-api-demos)
>* 中文版：[Electron API 示例（Github）](https://github.com/demopark/electron-api-demos-Zh_CN)
>* 中文版：[Electron API 示例 (Gitee)](https://gitee.com/shiyulanxuan/electron-api-demos-Zh_CN)(克隆自Github，[翻译者：demopark](https://github.com/demopark))

**Enjoy!**
