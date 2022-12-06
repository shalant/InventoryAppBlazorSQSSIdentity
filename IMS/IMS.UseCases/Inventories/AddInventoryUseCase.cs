﻿using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginDependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
