select p.Name, c.Name from Products as p
left join Products_Categories as pc on pc.ProductId = p.Id
left join Categories as c on c.Id = pc.CategoryId

-- либо

select concat(p.Name , ' - ', IIF(c.Name is null, '', c.Name)) as [Pair] from Products as p
left join Products_Categories as pc on pc.ProductId = p.Id
left join Categories as c on c.Id = pc.CategoryId