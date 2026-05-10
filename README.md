# Basic Web Development Project

ใน Solution นี้มี 2 Projects คือ **BasicWebDevelopmentProject** และ **BasicWebDevelopmentProject.Tests** โดยการทำงานต้องทำการติดตั้ง .Net 10 SDK เพื่อใช้ในการ Run

## คำสั่งในการทำงาน
การโดยทั่วไป .net core จะใช้คำสั่ง ดังต่อไปนี้ในการทำงาน

1. การ compile code จะใช้คำสั่ง
```
dotnet build
```

2. การ run code จะใช้คำสั่ง
```
dotnet run
```


3. การ run unit test จะใช้คำสั่ง
```
dotnet test
```


## โจทย์

1. จาก code ตั้งต้น จงเขียน Function **ValidateCreditCard** เพื่อตรวจสอบข้อมูลบัตรเครดิต ด้วย [Luhn algorithm](https://stripe.com/en-th/resources/more/how-to-use-the-luhn-algorithm-a-guide-in-applications-for-businesses)
2. จาก code ตั้งต้น จงเขียน Function **ValidateCitizenId** เพื่อตรวจสอบความถูกต้องของหมายเลขบัตรประชาชน ด้วยการ [Check Digit](https://idcard.memo8.com/)
3. สามารถเขียน function validate ในฝั่ง js เมื่อ user พิมพ์ได้ครบ ให้แสดงผลในทันทีก่อนที่จะ Submit มาที่ Function **SubmitData** 
4. เมื่อกดปุ่ม "Submit Information" บนหน้าจอ ข้อมูลต้องถูกตรวจสอบใน Function **SubmitData** เพื่อแสดงผลว่าข้อมูลถูกต้องหรือไม่
5. ทั้งสอง Functions ต้องมีการเขียน **Unit tests** ครอบใน Project **BasicWebDevelopmentProject.Tests**


---
## Reference
- [วิธีการคำนวณเพื่อตรวจสอบเลขบัตรประชาชนไทย](https://idcard.memo8.com/)
- [What is the Luhn algorithm and how does it work?](https://stripe.com/en-th/resources/more/how-to-use-the-luhn-algorithm-a-guide-in-applications-for-businesses)


