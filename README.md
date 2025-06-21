# CedarAPI Development Bridge

**What is Cedar?**  
Cedar is a policy language and engine developed by AWS, designed to make fine-grained authorization decisions easy and scalable. It powers [Amazon Verified Permissions (AVP)](https://docs.aws.amazon.com/verifiedpermissions/) by allowing developers to define, evaluate, and manage access control policies independently of application logic.

## 🎯 Purpose

This project provides a lightweight bridge to use the Cedar engine locally in development environments **without requiring AWS Verified Permissions** or installing Rust and Cedar CLI manually. It runs a containerized HTTP API over the Cedar CLI engine.

## 🚀 Getting Started

### 1. Clone and Run with Docker Compose

```bash
docker compose up --build
```

### 2. Test

Run ```CedarAPI.http``` file to test it.

### 3. Optional: Run Without Docker

If `cedar` CLI is installed on your local machine, you can run the project without Docker. Simply execute:

```bash
dotnet run --project CedarAPI
```

## 🛠 Future Improvements

- ✅ Mount `configs/` directory as a bind volume for live policy updates.
- ✅ Live reload support for configs.
- 📦 Add multi-principal entity examples and policy hierarchy.
- 🔐 Add support for context and attribute-based authorization.
- 🧪 Add integration tests for evaluation scenarios.

## 🌍 Other Languages

📄 [نسخه فارسی (Persian)](README.fa.md)