USE [Rusnak_laba2]
GO

INSERT INTO [dbo].[Kafedra]
           ([Kafedra_id]
           ,[Kafedra_name]
           ,[Kafedra_zav]
           ,[Count_Doctor_Science]
           ,[Inst_Kaf_FK])
     VALUES
           (1, '����', '�����', 10, 1),
		   (2, '���', '������', 7, 1),
		   (3, '���', '������', 5, 1),
			(4, '���', '�����', 3, 2),
			(5, '��', '�����', 7, 3),
			(6, '��', '����������', 5, 3),
			(7, '��', '�����', 5, 4),
			(8, '��', '������', 7, 5)
GO


