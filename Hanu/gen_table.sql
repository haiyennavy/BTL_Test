-- Tạo cơ sở dữ liệu
CREATE DATABASE FoodOrderDB;
GO

USE FoodOrderDB;
GO

-- Bảng Users (Người dùng)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    UserRole NVARCHAR(20) DEFAULT 'Customer' -- Customer, Admin
);

-- Bảng Categories (Danh mục món ăn)
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);

-- Bảng Foods (Món ăn)
CREATE TABLE Foods (
    FoodID INT PRIMARY KEY IDENTITY(1,1),
    FoodName NVARCHAR(100) NOT NULL,
    CategoryID INT,
    Description NVARCHAR(255),
    Price DECIMAL(10,2) NOT NULL,
    ImageName NVARCHAR(100),
    IsAvailable BIT DEFAULT 1,
	Quantity INT DEFAULT 0 NOT NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Bảng Orders (Đơn hàng)
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(50) DEFAULT 'Pending', -- Pending, Confirmed, Delivering, Delivered, Cancelled
    DeliveryAddress NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    PaymentMethod NVARCHAR(50) DEFAULT 'Cash',
    Notes NVARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Bảng OrderDetails (Chi tiết đơn hàng)
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    FoodID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (FoodID) REFERENCES Foods(FoodID)
);

-- Bảng Ratings (Đánh giá)
CREATE TABLE Ratings (
    RatingID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    UserID INT NOT NULL,
    Rating INT NOT NULL, -- 1 to 5
    Comment NVARCHAR(MAX),
    RatingDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO