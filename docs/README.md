# Schola Mimic 学习文档

这个目录记录 Schola Mimic 的设计过程、原版 Schola 的拆解结果、实现选择和开发笔记。
这里的内容面向项目作者，用于回答“为什么这样设计”和“它与原版有什么关系”。

面向普通使用者的安装、训练和推理说明应放在
`Schola-mimic/docs/`，不要与本目录混合。

## 文档索引

- [技术设计文档](./technical-design-document.md)

## 文档约定

- `TDD` 表示 Technical Design Document，不表示 Test-Driven Development。
- 文档中的“原版”指用于学习的 AMD Schola 1.3。
- 可以直接复用原版代码，但应记录来源和修改点，方便比较和学习。
- 设计变化先更新 TDD，再进入实现；实现中的小修正可在完成后同步回写。

