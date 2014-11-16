程序中需要调用系统命令行执行git命令，而在Windows系统中，通过系统命令行（cmd）去执行命令是通过查找指定目录的应用程序来实现的，所以有必要手动在环境变量中添加git的bin和git-core目录进行简单设置，详细步骤如下：

1. 找到git安装路径中bin的位置，如：D:\Program Files\Git\bin
2. 找到git安装路径中git-core的位置，如：D:\Program Files\Git\libexec\git-core;
3. 注："D:\Program Files\Git\"是Git的安装路径，可能与你的安装路径不一样，要按照你自己的路径替换"D:\Program Files\Git\"
4. 右键“计算机”->“属性”->“高级系统设置”->“环境变量”->在下方的“系统变量”中找到“path”->选中“path”并选择“编辑”
5. 将1和2中找到的bin和git-core完整路径复制在path中（path中原有值不要更改，在原有值基础上加英文分号;每条隔开）
6. 保存并退出