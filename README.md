# dotATM
dotATM 是一個模擬自動提款機 (ATM) 功能的 C# 專案，包含使用者資訊管理、帳戶操作等功能。


## 使用者資訊

有關使用者的資訊的 class 位於 `Services/AccountService.cs`，使用範例請看同目錄底下的 `ExampleUsage.cs`。


### 範例測試

範例測試檔案為 `Services/ExampleUsage.cs`，欲執行該測試檔案，請：

- 於專案管理（Solution Explorer） 頁面右鍵 dotATM（本次專案），並於 一般(General) > 輸出種類(Output type) 切換至 **控制台應用程式 (Console Application)**
- 打開 Program.cs，**取消註解第一行**

欲切換回來，請：
- 於專案管理（Solution Explorer） 頁面右鍵 dotATM（本次專案），並於 一般(General) > 輸出種類(Output type) 切換至 **視窗應用程式 (Windows Application)**
- 打開 Program.cs，**註解第一行**

請注意，請盡量不要 commit 到你修改過的 Program.cs，避免之後 merge 到測試 code。XD
