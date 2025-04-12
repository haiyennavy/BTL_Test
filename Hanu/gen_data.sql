-- Thêm dữ liệu mẫu vào bảng Users
--- pass default
-- 123456 = 8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92
INSERT INTO Users (Username, Password, FullName, Phone, Email, Address, UserRole)
VALUES 
('admin', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Quản trị viên', '0900000000', 'admin@foodorder.com', N'123 Đường Admin', 'Admin'),
('user1', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nguyễn Văn A', '0901234567', 'user1@example.com', N'456 Đường ABC, Quận 1', 'Customer'),
('user2', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Trần Thị B', '0909876543', 'user2@example.com', N'789 Đường XYZ, Quận 2', 'Customer');

-- Thêm dữ liệu mẫu vào bảng Categories
INSERT INTO Categories (CategoryName, Description)
VALUES 
(N'Cơm', N'Các món cơm'),
(N'Phở', N'Các loại phở'),
(N'Bún', N'Các món bún'),
(N'Đồ uống', N'Nước uống, giải khát');

-- Thêm dữ liệu mẫu vào bảng Foods
INSERT INTO Foods (FoodName, CategoryID, Description, Price, ImageName, Quantity, IsAvailable)
VALUES 
(N'Cơm Sườn', 1, N'Cơm, sườn nướng, đồ chua', 45000, 'com_suon.jpg', 1, 1),
(N'Cơm Gà', 1, N'Cơm, gà rán, sốt cay', 45000, 'com_ga.jpg', 1, 1),
(N'Phở Bò', 2, N'Phở, bò tái, bò chín', 55000, 'pho_bo.jpg',5, 1),
(N'Bún Chả', 3, N'Bún, chả nướng, nước mắm', 50000, 'bun_cha.jpg', 10, 1),
(N'Trà Sữa Trân Châu', 4, N'Trà sữa, trân châu đen', 35000, 'tra_sua.jpg', 0, 1),
(N'Cà Phê Đen', 4, N'Cà phê nguyên chất', 25000, 'ca_phe_den.jpg',0 , 1);

-- Thêm dữ liệu mẫu vào bảng Orders
INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status, DeliveryAddress, PhoneNumber, PaymentMethod, Notes)
VALUES 
(2, '2025-03-18 12:30:00', 120000, 'Delivered', N'456 Đường ABC, Quận 1', '0901234567', 'Cash', N'Không hành, ít ớt'),
(3, '2025-03-17 18:45:00', 135000, 'Delivering', N'789 Đường XYZ, Quận 2', '0909876543', 'Card', N'');

-- Thêm dữ liệu mẫu vào bảng OrderDetails
INSERT INTO OrderDetails (OrderID, FoodID, Quantity, UnitPrice)
VALUES 
(1, 1, 1, 45000), -- Cơm Sườn
(1, 5, 2, 35000), -- Trà Sữa Trân Châu
(2, 3, 2, 55000), -- Phở Bò
(2, 6, 1, 25000); -- Cà Phê Đen

-- Thêm dữ liệu mẫu vào bảng Ratings
INSERT INTO Ratings (OrderID, UserID, Rating, Comment, RatingDate)
VALUES 
(1, 2, 4, N'Đồ ăn ngon, giao hàng nhanh', '2025-03-18 14:00:00');
GO