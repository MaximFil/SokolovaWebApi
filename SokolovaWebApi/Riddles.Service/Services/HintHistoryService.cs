﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riddles.DAL.Entities;
using Riddles.Repository.Repositories;

namespace Riddles.Service.Services
{
    public class HintHistoryService
    {
        private readonly HintHistoryRepository hintHistoryRepository;

        public HintHistoryService()
        {
            hintHistoryRepository = new HintHistoryRepository();
        }

        public void CreateHintHistory(GameSessionUseHintHistory hintHistory, string hintName)
        {
            try
            {
                hintHistoryRepository.CreateHintHIstory(hintHistory, hintName);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
