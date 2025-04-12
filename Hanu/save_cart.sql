-- Tạo bảng lưu giỏ hàng
CREATE TABLE SavedCarts (
    CartID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    FoodID INT NOT NULL,
    Quantity INT NOT NULL,
    SavedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (FoodID) REFERENCES Foods(FoodID)
);

-- Tạo index để tăng tốc truy vấn
CREATE INDEX IDX_SavedCarts_UserID ON SavedCarts(UserID);