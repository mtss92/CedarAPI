<div dir="rtl">


<p dir="rtl">

# واسط CedarAPI برای محیط توسعه

**Cedar چیست؟**  
Cedar یک زبان و موتور سیاست‌گذاری (Policy) است که توسط AWS توسعه یافته و در سرویس [Amazon Verified Permissions](https://docs.aws.amazon.com/verifiedpermissions/) استفاده می‌شود. این زبان به شما اجازه می‌دهد سیاست‌های دسترسی را به صورت مستقل از کد اپلیکیشن تعریف و اجرا کنید.

## 🎯 هدف پروژه

این ابزار یک API سبک وزن فراهم می‌کند تا در محیط توسعه، بدون نیاز به استفاده از AVP یا نصب وابستگی‌هایی مانند Rust و Cedar CLI، بتوان از قدرت Cedar بهره‌مند شد.

## 🚀 نصب و راه‌اندازی

### 1. اجرا با Docker Compose

```bash
docker compose up --build
```

### 2. تست

پس از اجرای docker compose این API را میتوانید با استفاده از ```Postman``` و یا اجرای فایل ```CedarAPI.http``` تست نمایید.


### 3. اجرا بدون Docker (اختیاری)

در صورتی که CLI مربوط به cedar روی سیستم شما نصب باشد، می‌توانید پروژه را بدون داکر هم اجرا کنید:

```bash
dotnet run --project CedarAPI
```

## 🛠 ویژگی‌های آتی

- ✅ استفاده از Volume برای پوشه‌ی `configs` جهت آپدیت لحظه‌ای سیاست‌ها
- 📦 نمونه‌های پیشرفته‌تر برای کاربران مختلف و سلسله‌مراتب دسترسی
- 🔐 پشتیبانی از attribute-based authorization و context
- 🧪 افزودن تست‌های یکپارچه برای سناریوهای مختلف

## 🌍 زبان‌های دیگر

📄 [English Version](README.md)

</p>

</div>
