////js
	nvm install node-version – install a version of Node
	nvm list – see the versions of Node you have installed on your machine
	nvm use node-version – use a specific version of Node
	
	// Cài đặt cho .net core
	npm install bootstrap
	npm install jquery
	npm install popper.js

 	Phím tắt :
	- tạo seter , geter nhanh CTRL + R + E
	- FORMAT TOÀN BỘ CODE : CTRL + K+ D
	- FORMAT ĐOẠN CODE BÔI ĐEN : CTRL + K + F
	- XÓA DÒNG CODE HIỆN TẠI CỦA CON TRỎ: CTRL + L
	- COMMENT / UNCOMMENT : CTRL + K + C/U
	- THAY TÊN BIẾN HÀNG LOẠT : ALT + SHIFT + F10 + ENTER
	- CHUYỂN THÀNH CHỮ THƯỜNG/HOA : CTRL + U , CTRL + SHIFT + U
	
	SNIPPET CODE :
	- FOR TAB 
	- CW TAB
	- CTORS
	
	CTRL + ALT + L : mở solution exploer
	để tự xuống dòng theo kích thước màn hình
	vào option tìm mục Wordwrap bật lên nhé
	
	shift + down arrow : chọn
	
	
		Display template options with:
   dotnet new console -h
	Display all installed templates with:
	   dotnet new list
	Display templates available on NuGet.org with:
	   dotnet new search web
	   
	   dotnet --list-sdks
	   -emtypy web : dotnet new web (dotnet new web -f net5.0 -o MyWebProjectNet5)
    	<TargetFramework>net6.0</TargetFramework> rồi chạy dotnet restore để chạy watch trên .net 5
	   -run project : dotnet run \ dotnet watch run
	-Enable HTTPS : dotnet dev-certs https --clean , dotnet dev-certs https --trust 
