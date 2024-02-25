SELECT Products.Name as "Имя продукта", Categories.Name as "Имя категории"
FROM Products 
	LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
        LEFT JOIN Categories ON Categories.Id = ProductCategories.CategoryId