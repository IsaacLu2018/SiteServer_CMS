# SiteServer CMS

SiteServer CMS 基于.NET 平台，能够以最低的成本、最少的人力投入在最短的时间内架设一个功能齐全、性能优异、规模庞大并易于维护的网站平台。
# 本版本是基于开源的SiteServer基础上开发 原地址：@https://github.com/siteserver/cms

![SiteServer CMS](https://sscms.com/assets/images/github-banner.png)

## 开发文档

[《STL 语言参考手册》](https://sscms.com/docs/v6/stl/)

[《插件开发参考手册》](https://sscms.com/docs/v6/plugins/)

[《CLI 命令行参考手册》](https://sscms.com/docs/v6/cli/)

[《REST API 参考手册》](https://sscms.com/docs/v6/api/)

[《数据结构参考手册》](https://sscms.com/docs/v6/model/)

系统使用文档请点击 [SiteServer CMS 文档中心](https://sscms.com/docs/)

## SiteServer CMS 源码结构

```code
│ siteserver.sln                  Visual Studio 项目文件
│
├─SiteServer.BackgroundPages      ASP.NET 页面源文件
├─SiteServer.Cli                  命令行工具
├─SiteServer.CMS                  CMS 源文件
├─SiteServer.Utils                基础类库
└─SiteServer.API                  API 源文件及页面
```

## 生成安装包

```code
一、Visual Studio 切换解决方案配置到Release，编译
二、安装NodeJs
三、打开命令行，运行 npm install gulp -g
四、命令行，转到根目录，运行 npm install
五、命令行，运行 gulp build
六、命令行，运行 gulp zip
```

结束后会在根目录看到 siteserver_install.zip，这就是安装包了。
以上步骤是第一次生成安装包所需要执行的操作，如果已经生成过安装包：

```code
一、命令行，转到根目录，运行 gulp build
二、命令行，运行 gulp zip
```

## 贡献代码

代码贡献有很多形式，从提交问题，撰写文档，到提交代码，我们欢迎任何形式的贡献！

项目编译需要使用 Visual Studio 2017，你可以从这里下载 [Visual Studio Community 2017](https://www.visualstudio.com/downloads/)

- 1、Fork
- 2、创建您的特性分支 (`git checkout -b my-new-feature`)
- 3、提交您的改动 (`git commit -am 'Added some feature'`)
- 4、将您的修改记录提交到远程 `git` 仓库 (`git push origin my-new-feature`)
- 5、然后到 github 网站的该 `git` 远程仓库的 `my-new-feature` 分支下发起 Pull Request（请提交到 `dev` 分支，不要直接提交到 `master` 分支）

Copyright (C) 2003-2019 SiteServer CMS
