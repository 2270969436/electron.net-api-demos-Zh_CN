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
