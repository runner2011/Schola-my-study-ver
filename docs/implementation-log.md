# Schola Mimic 实现记录

本文档记录实际开发结果、验证命令，以及实现和 TDD 之间出现的差异。

## 2026-08-02：M0 项目骨架

### 本次目标

建立一个不依赖 ScholaExamples 的独立 UE 宿主工程、`ScholaMimic` Runtime
插件和最小 Python 包。该阶段不实现 UE/Python 通信。

### 已实现

- 独立 UE 工程：`Schola-mimic/ScholaMimicHost.uproject`。
- Runtime 插件：`Schola-mimic/Plugins/ScholaMimic`。
- 插件模块启动和关闭日志类别：`LogScholaMimic`。
- Python 包：`Schola-mimic/python/src/schola_mimic`。
- Python editable install 和 pytest 冒烟测试。
- UE/Python 生成文件忽略规则。
- 面向使用者的 Getting Started 文档。

### 结构决策

宿主工程直接放在 `Schola-mimic/`，而不是使用原版 ScholaExamples。这样可以确认
Mimic 插件没有意外依赖原版插件、资产或配置。宿主名称使用
`ScholaMimicHost`，插件和 Python 包使用 `ScholaMimic` / `schola_mimic`。

### 验证结果

Python 环境：`/home/runner2011/App/miniconda3/envs/schola/bin/python`

```text
python -m pip install -e .
Successfully installed schola-mimic-0.1.0

python -m pytest -q
1 passed
```

UE 5.7.4：

```text
Build.sh ScholaMimicHostEditor Linux Development -Project=<uproject>
Result: Succeeded
```

无界面启动日志已经确认 `Mounting Project plugin ScholaMimic`。本机首次 headless
Editor 启动长时间等待 Zen/DDC，测试进程在超时后退出，尚未用该方式观察到
`StartupModule()` 的 Display 日志。编译和插件挂载均已成功；正常 Editor 启动验证留在
M0 收尾时完成。

### 下一步

完成 M1 Transport。先冻结 framing 的字节级格式，并用 Python 实现编码、拆包和测试，
再实现 UE TCP Server，避免两端同时开发时无法判断错误属于哪一侧。
