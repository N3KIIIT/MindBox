SELECT Products.Name as "��� ��������", Categories.Name as "��� ���������"
FROM Products 
	LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
        LEFT JOIN Categories ON Categories.Id = ProductCategories.CategoryId