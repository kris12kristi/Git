USE [Rusnak_laba2]
GO

INSERT INTO [dbo].[Kafedra]
           ([Kafedra_id]
           ,[Kafedra_name]
           ,[Kafedra_zav]
           ,[Count_Doctor_Science]
           ,[Inst_Kaf_FK])
     VALUES
           (1, 'САПР', 'Лобур', 10, 1),
		   (2, 'ІСМ', 'Литвин', 7, 1),
		   (3, 'АСУ', 'Дворян', 5, 1),
			(4, 'КСА', 'Дербіж', 3, 2),
			(5, 'МО', 'Лютий', 7, 3),
			(6, 'МЛ', 'Конопляний', 5, 3),
			(7, 'БД', 'Карий', 5, 4),
			(8, 'АП', 'Возняк', 7, 5)
GO


