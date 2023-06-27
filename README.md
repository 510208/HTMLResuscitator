# HTMLResuscitator

HTMLResuscitator 是一個使用 VB.NET 開發的軟體，可以讓您以固定間隔重新載入 HTML 檔案或網頁，方便進行網站開發。

## 🚀 功能特點

- 自動以指定的間隔重新載入 HTML 檔案或網頁。
- 使用簡單的介面載入和查看 HTML 內容。
- 能夠提取並顯示載入網頁的 HTML 代碼。
- 具備 **WebView2** 控件相容性，提供更強大的網頁瀏覽功能。

## 🔧 前置需求

在使用 HTMLResuscitator 之前，請確保滿足以下需求：

- Windows 7+ 作業系統
- [.NET Framework 4.7](https://go.microsoft.com/fwlink/?linkid=863265) 或更新版本
- 已安裝 [WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703)（請參考安裝說明）

## 📥 安裝

1. 從 Releases 頁面下載 HTMLResuscitator 的最新版本。
2. 將下載的 ZIP 檔案解壓縮到電腦上的任意位置。
3. 根據以下步驟安裝 WebView2 Runtime：
   - 前往 Microsoft Edge WebView2 下載頁面（https://go.microsoft.com/fwlink/p/?LinkId=2124703）。
   - 根據您的系統架構（x86 或 x64）下載並安裝 WebView2 Runtime 套件。
4. 執行 "HTMLResuscitator.exe" 檔案來啟動 HTMLResuscitator。

## 📖 使用方法

1. 開啟 HTMLResuscitator。
2. 點擊 `"..."` 按鈕以瀏覽並選擇 HTML 檔案，或輸入網頁的 URL。
3. 使用提供的選項配置重新載入的間隔(進入右上角"檔案" -> "組態設定")。
4. 點擊 "開始" 按鈕以開始重新載入過程。
5. 網頁內容將顯示在 WebView 區域中。
6. 若要查看載入網頁的 HTML 代碼，請點擊 "顯示 HTML" 按鈕。

## 🤝 貢獻

歡迎對 HTMLResuscitator 進行貢獻！如果您有任何建議、錯誤報告或功能需求，請在 GitHub 倉庫（連結到您的倉庫）中提出問題。

## 📜 授權

HTMLResuscitator 使用 [MIT 授權](https://opensource.org/licenses/MIT) 進行發佈。根據授權條款，您可以自由修改和分發此軟體。

## 🙏 鳴謝

HTMLResuscitator 使用以下函式庫和框架：

- VB.NET
- WebView2 控件
- .NET Framework

感謝以下使用者或機關單位協助此軟體的開發：

- 510208
- Microsoft VisualStudio 2019
- GitHub
- Microsoft Visual Studio Code

## 📞 聯絡方式

如果您有任何問題或需要進一步的協助，請聯繫 [xux510208@gmail.com](mailto:xux510208@gmail.com)。

## 🐞 已知錯蟲

1. 部分時候在網址欄輸入檔案路徑會將其視為網域，建議透過檔案開啟功能開啟檔案以防止此問題。

---

感謝您使用 HTMLResuscitator！希望它能提升您的網站開發體驗。
