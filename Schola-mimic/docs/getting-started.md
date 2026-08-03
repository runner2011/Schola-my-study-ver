# Getting Started

## Prerequisites

- Unreal Engine 5.7 built for Linux
- Python 3.10 or newer
- `pip` and `pytest`

## Build the Unreal project

From the Unreal Engine root directory:

```bash
Engine/Build/BatchFiles/Linux/Build.sh \
  ScholaMimicHostEditor Linux Development \
  -Project="/absolute/path/to/Schola-mimic/ScholaMimicHost.uproject"
```

On a successful Editor startup, the log contains:

```text
Schola Mimic runtime module started
```

## Install the Python package

From `Schola-mimic/python`:

```bash
python -m pip install -e .
python -m pytest
```
