/*
 * Copyright (c) 2012 Alexander Houben (ahouben@greenliff.com)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do
 * so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
// Auto-generated, do not modify
using System;

namespace BleDriver {
    public partial class BLE112 {

        public enum ble_classes
        {
            ble_cls_system,
            ble_cls_flash,
            ble_cls_attributes,
            ble_cls_connection,
            ble_cls_attclient,
            ble_cls_sm,
            ble_cls_gap,
            ble_cls_hardware,
            ble_cls_test,
        }

        public enum ble_command_ids
        {
            ble_cmd_system_reset_id = 0,
            ble_cmd_system_hello_id = 1,
            ble_cmd_system_address_get_id = 2,
            ble_cmd_system_reg_write_id = 3,
            ble_cmd_system_reg_read_id = 4,
            ble_cmd_system_get_counters_id = 5,
            ble_cmd_system_get_connections_id = 6,
            ble_cmd_system_read_memory_id = 7,
            ble_cmd_system_get_info_id = 8,
            ble_cmd_system_endpoint_tx_id = 9,
            ble_cmd_system_whitelist_append_id = 10,
            ble_cmd_system_whitelist_remove_id = 11,
            ble_cmd_system_whitelist_clear_id = 12,
            ble_cmd_system_endpoint_rx_id = 13,
            ble_cmd_system_endpoint_set_watermarks_id = 14,
            ble_cmd_flash_ps_defrag_id = 0,
            ble_cmd_flash_ps_dump_id = 1,
            ble_cmd_flash_ps_erase_all_id = 2,
            ble_cmd_flash_ps_save_id = 3,
            ble_cmd_flash_ps_load_id = 4,
            ble_cmd_flash_ps_erase_id = 5,
            ble_cmd_flash_erase_page_id = 6,
            ble_cmd_flash_write_words_id = 7,
            ble_cmd_attributes_write_id = 0,
            ble_cmd_attributes_read_id = 1,
            ble_cmd_attributes_read_type_id = 2,
            ble_cmd_attributes_user_read_response_id = 3,
            ble_cmd_attributes_user_write_response_id = 4,
            ble_cmd_connection_disconnect_id = 0,
            ble_cmd_connection_get_rssi_id = 1,
            ble_cmd_connection_update_id = 2,
            ble_cmd_connection_version_update_id = 3,
            ble_cmd_connection_channel_map_get_id = 4,
            ble_cmd_connection_channel_map_set_id = 5,
            ble_cmd_connection_features_get_id = 6,
            ble_cmd_connection_get_status_id = 7,
            ble_cmd_connection_raw_tx_id = 8,
            ble_cmd_attclient_find_by_type_value_id = 0,
            ble_cmd_attclient_read_by_group_type_id = 1,
            ble_cmd_attclient_read_by_type_id = 2,
            ble_cmd_attclient_find_information_id = 3,
            ble_cmd_attclient_read_by_handle_id = 4,
            ble_cmd_attclient_attribute_write_id = 5,
            ble_cmd_attclient_write_command_id = 6,
            ble_cmd_attclient_indicate_confirm_id = 7,
            ble_cmd_attclient_read_long_id = 8,
            ble_cmd_attclient_prepare_write_id = 9,
            ble_cmd_attclient_execute_write_id = 10,
            ble_cmd_attclient_read_multiple_id = 11,
            ble_cmd_sm_encrypt_start_id = 0,
            ble_cmd_sm_set_bondable_mode_id = 1,
            ble_cmd_sm_delete_bonding_id = 2,
            ble_cmd_sm_set_parameters_id = 3,
            ble_cmd_sm_passkey_entry_id = 4,
            ble_cmd_sm_get_bonds_id = 5,
            ble_cmd_sm_set_oob_data_id = 6,
            ble_cmd_gap_set_privacy_flags_id = 0,
            ble_cmd_gap_set_mode_id = 1,
            ble_cmd_gap_discover_id = 2,
            ble_cmd_gap_connect_direct_id = 3,
            ble_cmd_gap_end_procedure_id = 4,
            ble_cmd_gap_connect_selective_id = 5,
            ble_cmd_gap_set_filtering_id = 6,
            ble_cmd_gap_set_scan_parameters_id = 7,
            ble_cmd_gap_set_adv_parameters_id = 8,
            ble_cmd_gap_set_adv_data_id = 9,
            ble_cmd_gap_set_directed_connectable_mode_id = 10,
            ble_cmd_hardware_io_port_config_irq_id = 0,
            ble_cmd_hardware_set_soft_timer_id = 1,
            ble_cmd_hardware_adc_read_id = 2,
            ble_cmd_hardware_io_port_config_direction_id = 3,
            ble_cmd_hardware_io_port_config_function_id = 4,
            ble_cmd_hardware_io_port_config_pull_id = 5,
            ble_cmd_hardware_io_port_write_id = 6,
            ble_cmd_hardware_io_port_read_id = 7,
            ble_cmd_hardware_spi_config_id = 8,
            ble_cmd_hardware_spi_transfer_id = 9,
            ble_cmd_hardware_i2c_read_id = 10,
            ble_cmd_hardware_i2c_write_id = 11,
            ble_cmd_hardware_set_txpower_id = 12,
            ble_cmd_hardware_timer_comparator_id = 13,
            ble_cmd_test_phy_tx_id = 0,
            ble_cmd_test_phy_rx_id = 1,
            ble_cmd_test_phy_end_id = 2,
            ble_cmd_test_phy_reset_id = 3,
            ble_cmd_test_get_channel_map_id = 4,
            ble_cmd_test_debug_id = 5,
        }

        public enum ble_event_ids
        {
            ble_evt_system_boot_id = 0,
            ble_evt_system_debug_id = 1,
            ble_evt_system_endpoint_watermark_rx_id = 2,
            ble_evt_system_endpoint_watermark_tx_id = 3,
            ble_evt_system_script_failure_id = 4,
            ble_evt_flash_ps_key_id = 0,
            ble_evt_attributes_value_id = 0,
            ble_evt_attributes_user_read_request_id = 1,
            ble_evt_attributes_status_id = 2,
            ble_evt_connection_status_id = 0,
            ble_evt_connection_version_ind_id = 1,
            ble_evt_connection_feature_ind_id = 2,
            ble_evt_connection_raw_rx_id = 3,
            ble_evt_connection_disconnected_id = 4,
            ble_evt_attclient_indicated_id = 0,
            ble_evt_attclient_procedure_completed_id = 1,
            ble_evt_attclient_group_found_id = 2,
            ble_evt_attclient_attribute_found_id = 3,
            ble_evt_attclient_find_information_found_id = 4,
            ble_evt_attclient_attribute_value_id = 5,
            ble_evt_attclient_read_multiple_response_id = 6,
            ble_evt_sm_smp_data_id = 0,
            ble_evt_sm_bonding_fail_id = 1,
            ble_evt_sm_passkey_display_id = 2,
            ble_evt_sm_passkey_request_id = 3,
            ble_evt_sm_bond_status_id = 4,
            ble_evt_gap_scan_response_id = 0,
            ble_evt_gap_mode_changed_id = 1,
            ble_evt_hardware_io_port_status_id = 0,
            ble_evt_hardware_soft_timer_id = 1,
            ble_evt_hardware_adc_result_id = 2,
        }

        public enum system_endpoints
        {
            system_endpoint_api = 0,
            system_endpoint_test = 1,
            system_endpoint_script = 2,
            system_endpoint_usb = 3,
            system_endpoint_uart0 = 4,
            system_endpoint_uart1 = 5,
        }

        public enum attributes_attribute_change_reason
        {
            attributes_attribute_change_reason_write_request = 0,
            attributes_attribute_change_reason_write_command = 1,
            attributes_attribute_change_reason_write_request_user = 2,
        }

        public enum attributes_attribute_status_flag
        {
            attributes_attribute_status_flag_notify = 1,
            attributes_attribute_status_flag_indicate = 2,
        }

        public enum connection_connstatus
        {
            connection_connected = 1,
            connection_encrypted = 2,
            connection_completed = 4,
            connection_parameters_change = 8,
        }

        public enum attclient_attribute_value_types
        {
            attclient_attribute_value_type_read = 0,
            attclient_attribute_value_type_notify = 1,
            attclient_attribute_value_type_indicate = 2,
            attclient_attribute_value_type_read_by_type = 3,
            attclient_attribute_value_type_read_blob = 4,
            attclient_attribute_value_type_indicate_rsp_req = 5,
        }

        public enum sm_bonding_key
        {
            sm_bonding_key_ltk = 0x01,
            sm_bonding_key_addr_public = 0x02,
            sm_bonding_key_addr_static = 0x04,
            sm_bonding_key_irk = 0x08,
            sm_bonding_key_edivrand = 0x10,
            sm_bonding_key_csrk = 0x20,
            sm_bonding_key_masterid = 0x40,
        }

        public enum sm_io_capability
        {
            sm_io_capability_displayonly = 0,
            sm_io_capability_displayyesno = 1,
            sm_io_capability_keyboardonly = 2,
            sm_io_capability_noinputnooutput = 3,
            sm_io_capability_keyboarddisplay = 4,
        }

        public enum gap_address_type
        {
            gap_address_type_public = 0,
            gap_address_type_random = 1,
        }

        public enum gap_discoverable_mode
        {
            gap_non_discoverable = 0,
            gap_limited_discoverable = 1,
            gap_general_discoverable = 2,
            gap_broadcast = 3,
            gap_user_data = 4,
        }

        public enum gap_connectable_mode
        {
            gap_non_connectable = 0,
            gap_directed_connectable = 1,
            gap_undirected_connectable = 2,
            gap_scannable_connectable = 3,
        }

        public enum gap_discover_mode
        {
            gap_discover_limited = 0,
            gap_discover_generic = 1,
            gap_discover_observation = 2,
        }

        public enum gap_ad_types
        {
            gap_ad_type_none = 0,
            gap_ad_type_flags = 1,
            gap_ad_type_services_16bit_more = 2,
            gap_ad_type_services_16bit_all = 3,
            gap_ad_type_services_32bit_more = 4,
            gap_ad_type_services_32bit_all = 5,
            gap_ad_type_services_128bit_more = 6,
            gap_ad_type_services_128bit_all = 7,
            gap_ad_type_localname_short = 8,
            gap_ad_type_localname_complete = 9,
            gap_ad_type_txpower = 10,
        }

        public enum gap_advertising_policy
        {
            gap_adv_policy_all = 0,
            gap_adv_policy_whitelist_scan = 1,
            gap_adv_policy_whitelist_connect = 2,
            gap_adv_policy_whitelist_all = 3,
        }

        public enum gap_scan_policy
        {
            gap_scan_policy_all = 0,
            gap_scan_policy_whitelist = 1,
        }

        // define gap_scan_header_flags
        public const byte GAP_SCAN_HEADER_ADV_IND = 0;
        public const byte GAP_SCAN_HEADER_ADV_DIRECT_IND = 1;
        public const byte GAP_SCAN_HEADER_ADV_NONCONN_IND = 2;
        public const byte GAP_SCAN_HEADER_SCAN_REQ = 3;
        public const byte GAP_SCAN_HEADER_SCAN_RSP = 4;
        public const byte GAP_SCAN_HEADER_CONNECT_REQ = 5;
        public const byte GAP_SCAN_HEADER_ADV_DISCOVER_IND = 6;
        // define gap_AD_FLAGS
        public const byte GAP_AD_FLAG_LIMITED_DISCOVERABLE = 0x01;
        public const byte GAP_AD_FLAG_GENERAL_DISCOVERABLE = 0x02;
        public const byte GAP_AD_FLAG_BREDR_NOT_SUPPORTED = 0x04;
        public const byte GAP_AD_FLAG_SIMULTANEOUS_LEBREDR_CTRL = 0x10;
        public const byte GAP_AD_FLAG_SIMULTANEOUS_LEBREDR_HOST = 0x20;
        public const byte GAP_AD_FLAG_MASK = 0x1f;

        public class ble_msg_system_address_get_rsp_t
        {
            public bd_addr address;
        }

        public class ble_msg_system_reg_write_rsp_t
        {
            public int result;
        }

        public class ble_msg_system_reg_read_rsp_t
        {
            public int address;
            public int value;
        }

        public class ble_msg_system_get_counters_rsp_t
        {
            public int txok;
            public int txretry;
            public int rxok;
            public int rxfail;
            public int mbuf;
        }

        public class ble_msg_system_get_connections_rsp_t
        {
            public int maxconn;
        }

        public class ble_msg_system_read_memory_rsp_t
        {
            public int address;
            public byte[] data;
        }

        public class ble_msg_system_get_info_rsp_t
        {
            public int major;
            public int minor;
            public int patch;
            public int build;
            public int ll_version;
            public int protocol_version;
            public int hw;
        }

        public class ble_msg_system_endpoint_tx_rsp_t
        {
            public int result;
        }

        public class ble_msg_system_whitelist_append_rsp_t
        {
            public int result;
        }

        public class ble_msg_system_whitelist_remove_rsp_t
        {
            public int result;
        }

        public class ble_msg_system_endpoint_rx_rsp_t
        {
            public int result;
            public byte[] data;
        }

        public class ble_msg_system_endpoint_set_watermarks_rsp_t
        {
            public int result;
        }

        public class ble_msg_flash_ps_save_rsp_t
        {
            public int result;
        }

        public class ble_msg_flash_ps_load_rsp_t
        {
            public int result;
            public byte[] value;
        }

        public class ble_msg_flash_erase_page_rsp_t
        {
            public int result;
        }

        public class ble_msg_attributes_write_rsp_t
        {
            public int result;
        }

        public class ble_msg_attributes_read_rsp_t
        {
            public int handle;
            public int offset;
            public int result;
            public byte[] value;
        }

        public class ble_msg_attributes_read_type_rsp_t
        {
            public int handle;
            public int result;
            public byte[] value;
        }

        public class ble_msg_connection_disconnect_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_connection_get_rssi_rsp_t
        {
            public int connection;
            public int rssi;
        }

        public class ble_msg_connection_update_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_connection_version_update_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_connection_channel_map_get_rsp_t
        {
            public int connection;
            public byte[] map;
        }

        public class ble_msg_connection_channel_map_set_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_connection_features_get_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_connection_get_status_rsp_t
        {
            public int connection;
        }

        public class ble_msg_connection_raw_tx_rsp_t
        {
            public int connection;
        }

        public class ble_msg_attclient_find_by_type_value_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_read_by_group_type_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_read_by_type_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_find_information_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_read_by_handle_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_attribute_write_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_write_command_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_indicate_confirm_rsp_t
        {
            public int result;
        }

        public class ble_msg_attclient_read_long_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_prepare_write_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_execute_write_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_attclient_read_multiple_rsp_t
        {
            public int connection;
            public int result;
        }

        public class ble_msg_sm_encrypt_start_rsp_t
        {
            public int handle;
            public int result;
        }

        public class ble_msg_sm_delete_bonding_rsp_t
        {
            public int result;
        }

        public class ble_msg_sm_passkey_entry_rsp_t
        {
            public int result;
        }

        public class ble_msg_sm_get_bonds_rsp_t
        {
            public int bonds;
        }

        public class ble_msg_gap_set_mode_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_discover_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_connect_direct_rsp_t
        {
            public int result;
            public int connection_handle;
        }

        public class ble_msg_gap_end_procedure_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_connect_selective_rsp_t
        {
            public int result;
            public int connection_handle;
        }

        public class ble_msg_gap_set_filtering_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_set_scan_parameters_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_set_adv_parameters_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_set_adv_data_rsp_t
        {
            public int result;
        }

        public class ble_msg_gap_set_directed_connectable_mode_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_config_irq_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_set_soft_timer_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_adc_read_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_config_direction_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_config_function_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_config_pull_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_write_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_io_port_read_rsp_t
        {
            public int result;
            public int port;
            public int data;
        }

        public class ble_msg_hardware_spi_config_rsp_t
        {
            public int result;
        }

        public class ble_msg_hardware_spi_transfer_rsp_t
        {
            public int result;
            public int channel;
            public byte[] data;
        }

        public class ble_msg_hardware_i2c_read_rsp_t
        {
            public int result;
            public byte[] data;
        }

        public class ble_msg_hardware_i2c_write_rsp_t
        {
            public int written;
        }

        public class ble_msg_hardware_timer_comparator_rsp_t
        {
            public int result;
        }

        public class ble_msg_test_phy_end_rsp_t
        {
            public int counter;
        }

        public class ble_msg_test_get_channel_map_rsp_t
        {
            public byte[] channel_map;
        }

        public class ble_msg_test_debug_rsp_t
        {
            public byte[] output;
        }

        public void ble_cmd_system_reset(int boot_in_dfu)
        {
            log("ble_cmd_system_reset_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_reset_id;
            // data
            m_tx[idx++] = (byte)boot_in_dfu;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, true);
        }

        public void ble_cmd_system_hello()
        {
            log("ble_cmd_system_hello_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_hello_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public ble_msg_system_address_get_rsp_t ble_cmd_system_address_get()
        {
            log("ble_cmd_system_address_get_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_address_get_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_address_get_rsp_t res = new ble_msg_system_address_get_rsp_t();
            res.address = new bd_addr();
            for(int i = 0; i < res.address.Length; i++)
            {
                res.address.Address[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_system_reg_write_rsp_t ble_cmd_system_reg_write(int address, int value)
        {
            log("ble_cmd_system_reg_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_reg_write_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)(address >> 8);
            m_tx[idx++] = (byte)value;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_reg_write_rsp_t res = new ble_msg_system_reg_write_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_system_reg_read_rsp_t ble_cmd_system_reg_read(int address)
        {
            log("ble_cmd_system_reg_read_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_reg_read_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)(address >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_reg_read_rsp_t res = new ble_msg_system_reg_read_rsp_t();
            res.address = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.value = answer[idx++];
            return res;
        }

        public ble_msg_system_get_counters_rsp_t ble_cmd_system_get_counters()
        {
            log("ble_cmd_system_get_counters_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_get_counters_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_get_counters_rsp_t res = new ble_msg_system_get_counters_rsp_t();
            res.txok = answer[idx++];
            res.txretry = answer[idx++];
            res.rxok = answer[idx++];
            res.rxfail = answer[idx++];
            res.mbuf = answer[idx++];
            return res;
        }

        public ble_msg_system_get_connections_rsp_t ble_cmd_system_get_connections()
        {
            log("ble_cmd_system_get_connections_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_get_connections_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_get_connections_rsp_t res = new ble_msg_system_get_connections_rsp_t();
            res.maxconn = answer[idx++];
            return res;
        }

        public ble_msg_system_read_memory_rsp_t ble_cmd_system_read_memory(int address, int length)
        {
            log("ble_cmd_system_read_memory_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 4 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_read_memory_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)(address >> 8);
            m_tx[idx++] = (byte)(address >> 16);
            m_tx[idx++] = (byte)(address >> 24);
            m_tx[idx++] = (byte)length;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 4 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_read_memory_rsp_t res = new ble_msg_system_read_memory_rsp_t();
            res.address = answer[idx+0] | (answer[idx+1] << 8) | (answer[idx+2] << 16) | (answer[idx+3] << 24); idx+=4;
            res.data = new byte[answer[idx++]];
            for(int i = 0; i < res.data.Length; i++)
            {
                res.data[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_system_get_info_rsp_t ble_cmd_system_get_info()
        {
            log("ble_cmd_system_get_info_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_get_info_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_get_info_rsp_t res = new ble_msg_system_get_info_rsp_t();
            res.major = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.minor = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.patch = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.build = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.ll_version = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.protocol_version = answer[idx++];
            res.hw = answer[idx++];
            return res;
        }

        public ble_msg_system_endpoint_tx_rsp_t ble_cmd_system_endpoint_tx(int endpoint, byte[] data)
        {
            log("ble_cmd_system_endpoint_tx_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_tx_id;
            // data
            m_tx[idx++] = (byte)endpoint;
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_endpoint_tx_rsp_t res = new ble_msg_system_endpoint_tx_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_system_whitelist_append_rsp_t ble_cmd_system_whitelist_append(bd_addr address, int address_type)
        {
            log("ble_cmd_system_whitelist_append_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + address.Length + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_append_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                m_tx[idx++] = address.Address[i];
            }
            m_tx[idx++] = (byte)address_type;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + address.Length + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_whitelist_append_rsp_t res = new ble_msg_system_whitelist_append_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_system_whitelist_remove_rsp_t ble_cmd_system_whitelist_remove(bd_addr address, int address_type)
        {
            log("ble_cmd_system_whitelist_remove_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + address.Length + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_remove_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                m_tx[idx++] = address.Address[i];
            }
            m_tx[idx++] = (byte)address_type;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + address.Length + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_whitelist_remove_rsp_t res = new ble_msg_system_whitelist_remove_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_system_whitelist_clear()
        {
            log("ble_cmd_system_whitelist_clear_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_clear_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public ble_msg_system_endpoint_rx_rsp_t ble_cmd_system_endpoint_rx(int endpoint, int size)
        {
            log("ble_cmd_system_endpoint_rx_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_rx_id;
            // data
            m_tx[idx++] = (byte)endpoint;
            m_tx[idx++] = (byte)size;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_endpoint_rx_rsp_t res = new ble_msg_system_endpoint_rx_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.data = new byte[answer[idx++]];
            for(int i = 0; i < res.data.Length; i++)
            {
                res.data[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_system_endpoint_set_watermarks_rsp_t ble_cmd_system_endpoint_set_watermarks(int endpoint, int rx, int tx)
        {
            log("ble_cmd_system_endpoint_set_watermarks_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_system;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_set_watermarks_id;
            // data
            m_tx[idx++] = (byte)endpoint;
            m_tx[idx++] = (byte)rx;
            m_tx[idx++] = (byte)tx;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_system_endpoint_set_watermarks_rsp_t res = new ble_msg_system_endpoint_set_watermarks_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_flash_ps_defrag()
        {
            log("ble_cmd_flash_ps_defrag_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_defrag_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public void ble_cmd_flash_ps_dump()
        {
            log("ble_cmd_flash_ps_dump_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_dump_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public void ble_cmd_flash_ps_erase_all()
        {
            log("ble_cmd_flash_ps_erase_all_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_erase_all_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public ble_msg_flash_ps_save_rsp_t ble_cmd_flash_ps_save(int key, byte[] value)
        {
            log("ble_cmd_flash_ps_save_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 1 + value.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_save_id;
            // data
            m_tx[idx++] = (byte)key;
            m_tx[idx++] = (byte)(key >> 8);
            m_tx[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                m_tx[idx++] = value[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 1 + value.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_flash_ps_save_rsp_t res = new ble_msg_flash_ps_save_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_flash_ps_load_rsp_t ble_cmd_flash_ps_load(int key)
        {
            log("ble_cmd_flash_ps_load_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_load_id;
            // data
            m_tx[idx++] = (byte)key;
            m_tx[idx++] = (byte)(key >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_flash_ps_load_rsp_t res = new ble_msg_flash_ps_load_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.value = new byte[answer[idx++]];
            for(int i = 0; i < res.value.Length; i++)
            {
                res.value[i] = answer[idx++];
            }
            return res;
        }

        public void ble_cmd_flash_ps_erase(int key)
        {
            log("ble_cmd_flash_ps_erase_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_erase_id;
            // data
            m_tx[idx++] = (byte)key;
            m_tx[idx++] = (byte)(key >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2, false);
        }

        public ble_msg_flash_erase_page_rsp_t ble_cmd_flash_erase_page(int page)
        {
            log("ble_cmd_flash_erase_page_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_erase_page_id;
            // data
            m_tx[idx++] = (byte)page;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_flash_erase_page_rsp_t res = new ble_msg_flash_erase_page_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_flash_write_words(int address, byte[] words)
        {
            log("ble_cmd_flash_write_words_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 1 + words.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_flash;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_flash_write_words_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)(address >> 8);
            m_tx[idx++] = (byte)(words.Length);
            for(int i = 0; i < words.Length; i++)
            {
                m_tx[idx++] = words[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 1 + words.Length, false);
        }

        public ble_msg_attributes_write_rsp_t ble_cmd_attributes_write(int handle, int offset, byte[] value)
        {
            log("ble_cmd_attributes_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 1 + 1 + value.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attributes;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attributes_write_id;
            // data
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)(handle >> 8);
            m_tx[idx++] = (byte)offset;
            m_tx[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                m_tx[idx++] = value[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 1 + 1 + value.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attributes_write_rsp_t res = new ble_msg_attributes_write_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attributes_read_rsp_t ble_cmd_attributes_read(int handle, int offset)
        {
            log("ble_cmd_attributes_read_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attributes;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attributes_read_id;
            // data
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)(handle >> 8);
            m_tx[idx++] = (byte)offset;
            m_tx[idx++] = (byte)(offset >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attributes_read_rsp_t res = new ble_msg_attributes_read_rsp_t();
            res.handle = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.offset = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.value = new byte[answer[idx++]];
            for(int i = 0; i < res.value.Length; i++)
            {
                res.value[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_attributes_read_type_rsp_t ble_cmd_attributes_read_type(int handle)
        {
            log("ble_cmd_attributes_read_type_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attributes;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attributes_read_type_id;
            // data
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)(handle >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attributes_read_type_rsp_t res = new ble_msg_attributes_read_type_rsp_t();
            res.handle = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.value = new byte[answer[idx++]];
            for(int i = 0; i < res.value.Length; i++)
            {
                res.value[i] = answer[idx++];
            }
            return res;
        }

        public void ble_cmd_attributes_user_read_response(int connection, int att_error, byte[] value)
        {
            log("ble_cmd_attributes_user_read_response_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1 + value.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attributes;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attributes_user_read_response_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)att_error;
            m_tx[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                m_tx[idx++] = value[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1 + value.Length, false);
        }

        public void ble_cmd_attributes_user_write_response(int connection, int att_error)
        {
            log("ble_cmd_attributes_user_write_response_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attributes;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attributes_user_write_response_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)att_error;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
        }

        public ble_msg_connection_disconnect_rsp_t ble_cmd_connection_disconnect(int connection)
        {
            log("ble_cmd_connection_disconnect_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_disconnect_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_disconnect_rsp_t res = new ble_msg_connection_disconnect_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_connection_get_rssi_rsp_t ble_cmd_connection_get_rssi(int connection)
        {
            log("ble_cmd_connection_get_rssi_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_get_rssi_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_get_rssi_rsp_t res = new ble_msg_connection_get_rssi_rsp_t();
            res.connection = answer[idx++];
            res.rssi = answer[idx++];
            return res;
        }

        public ble_msg_connection_update_rsp_t ble_cmd_connection_update(int connection, int interval_min, int interval_max, int latency, int timeout)
        {
            log("ble_cmd_connection_update_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2 + 2 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_update_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)interval_min;
            m_tx[idx++] = (byte)(interval_min >> 8);
            m_tx[idx++] = (byte)interval_max;
            m_tx[idx++] = (byte)(interval_max >> 8);
            m_tx[idx++] = (byte)latency;
            m_tx[idx++] = (byte)(latency >> 8);
            m_tx[idx++] = (byte)timeout;
            m_tx[idx++] = (byte)(timeout >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2 + 2 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_update_rsp_t res = new ble_msg_connection_update_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_connection_version_update_rsp_t ble_cmd_connection_version_update(int connection)
        {
            log("ble_cmd_connection_version_update_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_version_update_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_version_update_rsp_t res = new ble_msg_connection_version_update_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_connection_channel_map_get_rsp_t ble_cmd_connection_channel_map_get(int connection)
        {
            log("ble_cmd_connection_channel_map_get_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_channel_map_get_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_channel_map_get_rsp_t res = new ble_msg_connection_channel_map_get_rsp_t();
            res.connection = answer[idx++];
            res.map = new byte[answer[idx++]];
            for(int i = 0; i < res.map.Length; i++)
            {
                res.map[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_connection_channel_map_set_rsp_t ble_cmd_connection_channel_map_set(int connection, byte[] map)
        {
            log("ble_cmd_connection_channel_map_set_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + map.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_channel_map_set_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)(map.Length);
            for(int i = 0; i < map.Length; i++)
            {
                m_tx[idx++] = map[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + map.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_channel_map_set_rsp_t res = new ble_msg_connection_channel_map_set_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_connection_features_get_rsp_t ble_cmd_connection_features_get(int connection)
        {
            log("ble_cmd_connection_features_get_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_features_get_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_features_get_rsp_t res = new ble_msg_connection_features_get_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_connection_get_status_rsp_t ble_cmd_connection_get_status(int connection)
        {
            log("ble_cmd_connection_get_status_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_get_status_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_get_status_rsp_t res = new ble_msg_connection_get_status_rsp_t();
            res.connection = answer[idx++];
            return res;
        }

        public ble_msg_connection_raw_tx_rsp_t ble_cmd_connection_raw_tx(int connection, byte[] data)
        {
            log("ble_cmd_connection_raw_tx_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_connection;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_connection_raw_tx_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_connection_raw_tx_rsp_t res = new ble_msg_connection_raw_tx_rsp_t();
            res.connection = answer[idx++];
            return res;
        }

        public ble_msg_attclient_find_by_type_value_rsp_t ble_cmd_attclient_find_by_type_value(int connection, int start, int end, int uuid, byte[] value)
        {
            log("ble_cmd_attclient_find_by_type_value_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2 + 2 + 1 + value.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_find_by_type_value_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)start;
            m_tx[idx++] = (byte)(start >> 8);
            m_tx[idx++] = (byte)end;
            m_tx[idx++] = (byte)(end >> 8);
            m_tx[idx++] = (byte)uuid;
            m_tx[idx++] = (byte)(uuid >> 8);
            m_tx[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                m_tx[idx++] = value[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2 + 2 + 1 + value.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_find_by_type_value_rsp_t res = new ble_msg_attclient_find_by_type_value_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_read_by_group_type_rsp_t ble_cmd_attclient_read_by_group_type(int connection, int start, int end, byte[] uuid)
        {
            log("ble_cmd_attclient_read_by_group_type_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + uuid.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_group_type_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)start;
            m_tx[idx++] = (byte)(start >> 8);
            m_tx[idx++] = (byte)end;
            m_tx[idx++] = (byte)(end >> 8);
            m_tx[idx++] = (byte)(uuid.Length);
            for(int i = 0; i < uuid.Length; i++)
            {
                m_tx[idx++] = uuid[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2 + 1 + uuid.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_read_by_group_type_rsp_t res = new ble_msg_attclient_read_by_group_type_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_read_by_type_rsp_t ble_cmd_attclient_read_by_type(int connection, int start, int end, byte[] uuid)
        {
            log("ble_cmd_attclient_read_by_type_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + uuid.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_type_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)start;
            m_tx[idx++] = (byte)(start >> 8);
            m_tx[idx++] = (byte)end;
            m_tx[idx++] = (byte)(end >> 8);
            m_tx[idx++] = (byte)(uuid.Length);
            for(int i = 0; i < uuid.Length; i++)
            {
                m_tx[idx++] = uuid[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2 + 1 + uuid.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_read_by_type_rsp_t res = new ble_msg_attclient_read_by_type_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_find_information_rsp_t ble_cmd_attclient_find_information(int connection, int start, int end)
        {
            log("ble_cmd_attclient_find_information_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_find_information_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)start;
            m_tx[idx++] = (byte)(start >> 8);
            m_tx[idx++] = (byte)end;
            m_tx[idx++] = (byte)(end >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_find_information_rsp_t res = new ble_msg_attclient_find_information_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_read_by_handle_rsp_t ble_cmd_attclient_read_by_handle(int connection, int chrhandle)
        {
            log("ble_cmd_attclient_read_by_handle_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_handle_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)chrhandle;
            m_tx[idx++] = (byte)(chrhandle >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_read_by_handle_rsp_t res = new ble_msg_attclient_read_by_handle_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_attribute_write_rsp_t ble_cmd_attclient_attribute_write(int connection, int atthandle, byte[] data)
        {
            log("ble_cmd_attclient_attribute_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_attribute_write_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)atthandle;
            m_tx[idx++] = (byte)(atthandle >> 8);
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_attribute_write_rsp_t res = new ble_msg_attclient_attribute_write_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_write_command_rsp_t ble_cmd_attclient_write_command(int connection, int atthandle, byte[] data)
        {
            log("ble_cmd_attclient_write_command_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_write_command_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)atthandle;
            m_tx[idx++] = (byte)(atthandle >> 8);
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_write_command_rsp_t res = new ble_msg_attclient_write_command_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_indicate_confirm_rsp_t ble_cmd_attclient_indicate_confirm(int connection)
        {
            log("ble_cmd_attclient_indicate_confirm_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_indicate_confirm_id;
            // data
            m_tx[idx++] = (byte)connection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_indicate_confirm_rsp_t res = new ble_msg_attclient_indicate_confirm_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_read_long_rsp_t ble_cmd_attclient_read_long(int connection, int chrhandle)
        {
            log("ble_cmd_attclient_read_long_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_long_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)chrhandle;
            m_tx[idx++] = (byte)(chrhandle >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_read_long_rsp_t res = new ble_msg_attclient_read_long_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_prepare_write_rsp_t ble_cmd_attclient_prepare_write(int connection, int atthandle, int offset, byte[] data)
        {
            log("ble_cmd_attclient_prepare_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_prepare_write_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)atthandle;
            m_tx[idx++] = (byte)(atthandle >> 8);
            m_tx[idx++] = (byte)offset;
            m_tx[idx++] = (byte)(offset >> 8);
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 2 + 2 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_prepare_write_rsp_t res = new ble_msg_attclient_prepare_write_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_execute_write_rsp_t ble_cmd_attclient_execute_write(int connection, int commit)
        {
            log("ble_cmd_attclient_execute_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_execute_write_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)commit;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_execute_write_rsp_t res = new ble_msg_attclient_execute_write_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_attclient_read_multiple_rsp_t ble_cmd_attclient_read_multiple(int connection, byte[] handles)
        {
            log("ble_cmd_attclient_read_multiple_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + handles.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_attclient;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_multiple_id;
            // data
            m_tx[idx++] = (byte)connection;
            m_tx[idx++] = (byte)(handles.Length);
            for(int i = 0; i < handles.Length; i++)
            {
                m_tx[idx++] = handles[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + handles.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_attclient_read_multiple_rsp_t res = new ble_msg_attclient_read_multiple_rsp_t();
            res.connection = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_sm_encrypt_start_rsp_t ble_cmd_sm_encrypt_start(int handle, int bonding)
        {
            log("ble_cmd_sm_encrypt_start_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_encrypt_start_id;
            // data
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)bonding;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_sm_encrypt_start_rsp_t res = new ble_msg_sm_encrypt_start_rsp_t();
            res.handle = answer[idx++];
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_sm_set_bondable_mode(int bondable)
        {
            log("ble_cmd_sm_set_bondable_mode_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_bondable_mode_id;
            // data
            m_tx[idx++] = (byte)bondable;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
        }

        public ble_msg_sm_delete_bonding_rsp_t ble_cmd_sm_delete_bonding(int handle)
        {
            log("ble_cmd_sm_delete_bonding_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_delete_bonding_id;
            // data
            m_tx[idx++] = (byte)handle;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_sm_delete_bonding_rsp_t res = new ble_msg_sm_delete_bonding_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_sm_set_parameters(int mitm, int min_key_size, int io_capabilities)
        {
            log("ble_cmd_sm_set_parameters_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_parameters_id;
            // data
            m_tx[idx++] = (byte)mitm;
            m_tx[idx++] = (byte)min_key_size;
            m_tx[idx++] = (byte)io_capabilities;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
        }

        public ble_msg_sm_passkey_entry_rsp_t ble_cmd_sm_passkey_entry(int handle, int passkey)
        {
            log("ble_cmd_sm_passkey_entry_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 4);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_passkey_entry_id;
            // data
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)passkey;
            m_tx[idx++] = (byte)(passkey >> 8);
            m_tx[idx++] = (byte)(passkey >> 16);
            m_tx[idx++] = (byte)(passkey >> 24);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 4, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_sm_passkey_entry_rsp_t res = new ble_msg_sm_passkey_entry_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_sm_get_bonds_rsp_t ble_cmd_sm_get_bonds()
        {
            log("ble_cmd_sm_get_bonds_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_get_bonds_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_sm_get_bonds_rsp_t res = new ble_msg_sm_get_bonds_rsp_t();
            res.bonds = answer[idx++];
            return res;
        }

        public void ble_cmd_sm_set_oob_data(byte[] oob)
        {
            log("ble_cmd_sm_set_oob_data_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + oob.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_sm;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_oob_data_id;
            // data
            m_tx[idx++] = (byte)(oob.Length);
            for(int i = 0; i < oob.Length; i++)
            {
                m_tx[idx++] = oob[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + oob.Length, false);
        }

        public void ble_cmd_gap_set_privacy_flags(int peripheral_privacy, int central_privacy)
        {
            log("ble_cmd_gap_set_privacy_flags_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_privacy_flags_id;
            // data
            m_tx[idx++] = (byte)peripheral_privacy;
            m_tx[idx++] = (byte)central_privacy;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
        }

        public ble_msg_gap_set_mode_rsp_t ble_cmd_gap_set_mode(int discover, int connect)
        {
            log("ble_cmd_gap_set_mode_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_mode_id;
            // data
            m_tx[idx++] = (byte)discover;
            m_tx[idx++] = (byte)connect;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_mode_rsp_t res = new ble_msg_gap_set_mode_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_discover_rsp_t ble_cmd_gap_discover(int mode)
        {
            log("ble_cmd_gap_discover_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_discover_id;
            // data
            m_tx[idx++] = (byte)mode;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_discover_rsp_t res = new ble_msg_gap_discover_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_connect_direct_rsp_t ble_cmd_gap_connect_direct(bd_addr address, int addr_type, int conn_interval_min, int conn_interval_max, int timeout, int latency)
        {
            log("ble_cmd_gap_connect_direct_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + address.Length + 1 + 2 + 2 + 2 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_connect_direct_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                m_tx[idx++] = address.Address[i];
            }
            m_tx[idx++] = (byte)addr_type;
            m_tx[idx++] = (byte)conn_interval_min;
            m_tx[idx++] = (byte)(conn_interval_min >> 8);
            m_tx[idx++] = (byte)conn_interval_max;
            m_tx[idx++] = (byte)(conn_interval_max >> 8);
            m_tx[idx++] = (byte)timeout;
            m_tx[idx++] = (byte)(timeout >> 8);
            m_tx[idx++] = (byte)latency;
            m_tx[idx++] = (byte)(latency >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + address.Length + 1 + 2 + 2 + 2 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_connect_direct_rsp_t res = new ble_msg_gap_connect_direct_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.connection_handle = answer[idx++];
            return res;
        }

        public ble_msg_gap_end_procedure_rsp_t ble_cmd_gap_end_procedure()
        {
            log("ble_cmd_gap_end_procedure_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_end_procedure_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_end_procedure_rsp_t res = new ble_msg_gap_end_procedure_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_connect_selective_rsp_t ble_cmd_gap_connect_selective(int conn_interval_min, int conn_interval_max, int timeout, int latency)
        {
            log("ble_cmd_gap_connect_selective_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 2 + 2 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_connect_selective_id;
            // data
            m_tx[idx++] = (byte)conn_interval_min;
            m_tx[idx++] = (byte)(conn_interval_min >> 8);
            m_tx[idx++] = (byte)conn_interval_max;
            m_tx[idx++] = (byte)(conn_interval_max >> 8);
            m_tx[idx++] = (byte)timeout;
            m_tx[idx++] = (byte)(timeout >> 8);
            m_tx[idx++] = (byte)latency;
            m_tx[idx++] = (byte)(latency >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 2 + 2 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_connect_selective_rsp_t res = new ble_msg_gap_connect_selective_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.connection_handle = answer[idx++];
            return res;
        }

        public ble_msg_gap_set_filtering_rsp_t ble_cmd_gap_set_filtering(int scan_policy, int adv_policy, int scan_duplicate_filtering)
        {
            log("ble_cmd_gap_set_filtering_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_filtering_id;
            // data
            m_tx[idx++] = (byte)scan_policy;
            m_tx[idx++] = (byte)adv_policy;
            m_tx[idx++] = (byte)scan_duplicate_filtering;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_filtering_rsp_t res = new ble_msg_gap_set_filtering_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_set_scan_parameters_rsp_t ble_cmd_gap_set_scan_parameters(int scan_interval, int scan_window, int active)
        {
            log("ble_cmd_gap_set_scan_parameters_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 2 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_scan_parameters_id;
            // data
            m_tx[idx++] = (byte)scan_interval;
            m_tx[idx++] = (byte)(scan_interval >> 8);
            m_tx[idx++] = (byte)scan_window;
            m_tx[idx++] = (byte)(scan_window >> 8);
            m_tx[idx++] = (byte)active;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 2 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_scan_parameters_rsp_t res = new ble_msg_gap_set_scan_parameters_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_set_adv_parameters_rsp_t ble_cmd_gap_set_adv_parameters(int adv_interval_min, int adv_interval_max, int adv_channels)
        {
            log("ble_cmd_gap_set_adv_parameters_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 2 + 2 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_adv_parameters_id;
            // data
            m_tx[idx++] = (byte)adv_interval_min;
            m_tx[idx++] = (byte)(adv_interval_min >> 8);
            m_tx[idx++] = (byte)adv_interval_max;
            m_tx[idx++] = (byte)(adv_interval_max >> 8);
            m_tx[idx++] = (byte)adv_channels;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 2 + 2 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_adv_parameters_rsp_t res = new ble_msg_gap_set_adv_parameters_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_set_adv_data_rsp_t ble_cmd_gap_set_adv_data(int set_scanrsp, byte[] adv_data)
        {
            log("ble_cmd_gap_set_adv_data_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + adv_data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_adv_data_id;
            // data
            m_tx[idx++] = (byte)set_scanrsp;
            m_tx[idx++] = (byte)(adv_data.Length);
            for(int i = 0; i < adv_data.Length; i++)
            {
                m_tx[idx++] = adv_data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + adv_data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_adv_data_rsp_t res = new ble_msg_gap_set_adv_data_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_gap_set_directed_connectable_mode_rsp_t ble_cmd_gap_set_directed_connectable_mode(bd_addr address, int addr_type)
        {
            log("ble_cmd_gap_set_directed_connectable_mode_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + address.Length + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_gap;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_directed_connectable_mode_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                m_tx[idx++] = address.Address[i];
            }
            m_tx[idx++] = (byte)addr_type;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + address.Length + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_gap_set_directed_connectable_mode_rsp_t res = new ble_msg_gap_set_directed_connectable_mode_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_config_irq_rsp_t ble_cmd_hardware_io_port_config_irq(int port, int enable_bits, int falling_edge)
        {
            log("ble_cmd_hardware_io_port_config_irq_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_irq_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)enable_bits;
            m_tx[idx++] = (byte)falling_edge;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_config_irq_rsp_t res = new ble_msg_hardware_io_port_config_irq_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_set_soft_timer_rsp_t ble_cmd_hardware_set_soft_timer(int time, int handle, int single_shot)
        {
            log("ble_cmd_hardware_set_soft_timer_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 4 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_set_soft_timer_id;
            // data
            m_tx[idx++] = (byte)time;
            m_tx[idx++] = (byte)(time >> 8);
            m_tx[idx++] = (byte)(time >> 16);
            m_tx[idx++] = (byte)(time >> 24);
            m_tx[idx++] = (byte)handle;
            m_tx[idx++] = (byte)single_shot;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 4 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_set_soft_timer_rsp_t res = new ble_msg_hardware_set_soft_timer_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_adc_read_rsp_t ble_cmd_hardware_adc_read(int input, int decimation, int reference_selection)
        {
            log("ble_cmd_hardware_adc_read_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_adc_read_id;
            // data
            m_tx[idx++] = (byte)input;
            m_tx[idx++] = (byte)decimation;
            m_tx[idx++] = (byte)reference_selection;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_adc_read_rsp_t res = new ble_msg_hardware_adc_read_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_config_direction_rsp_t ble_cmd_hardware_io_port_config_direction(int port, int direction)
        {
            log("ble_cmd_hardware_io_port_config_direction_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_direction_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)direction;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_config_direction_rsp_t res = new ble_msg_hardware_io_port_config_direction_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_config_function_rsp_t ble_cmd_hardware_io_port_config_function(int port, int function)
        {
            log("ble_cmd_hardware_io_port_config_function_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_function_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)function;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_config_function_rsp_t res = new ble_msg_hardware_io_port_config_function_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_config_pull_rsp_t ble_cmd_hardware_io_port_config_pull(int port, int tristate_mask, int pull_up)
        {
            log("ble_cmd_hardware_io_port_config_pull_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_pull_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)tristate_mask;
            m_tx[idx++] = (byte)pull_up;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_config_pull_rsp_t res = new ble_msg_hardware_io_port_config_pull_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_write_rsp_t ble_cmd_hardware_io_port_write(int port, int mask, int data)
        {
            log("ble_cmd_hardware_io_port_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_write_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)mask;
            m_tx[idx++] = (byte)data;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_write_rsp_t res = new ble_msg_hardware_io_port_write_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_io_port_read_rsp_t ble_cmd_hardware_io_port_read(int port, int mask)
        {
            log("ble_cmd_hardware_io_port_read_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_read_id;
            // data
            m_tx[idx++] = (byte)port;
            m_tx[idx++] = (byte)mask;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_io_port_read_rsp_t res = new ble_msg_hardware_io_port_read_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.port = answer[idx++];
            res.data = answer[idx++];
            return res;
        }

        public ble_msg_hardware_spi_config_rsp_t ble_cmd_hardware_spi_config(int channel, int polarity, int phase, int bit_order, int baud_e, int baud_m)
        {
            log("ble_cmd_hardware_spi_config_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_spi_config_id;
            // data
            m_tx[idx++] = (byte)channel;
            m_tx[idx++] = (byte)polarity;
            m_tx[idx++] = (byte)phase;
            m_tx[idx++] = (byte)bit_order;
            m_tx[idx++] = (byte)baud_e;
            m_tx[idx++] = (byte)baud_m;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_spi_config_rsp_t res = new ble_msg_hardware_spi_config_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public ble_msg_hardware_spi_transfer_rsp_t ble_cmd_hardware_spi_transfer(int channel, byte[] data)
        {
            log("ble_cmd_hardware_spi_transfer_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_spi_transfer_id;
            // data
            m_tx[idx++] = (byte)channel;
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_spi_transfer_rsp_t res = new ble_msg_hardware_spi_transfer_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.channel = answer[idx++];
            res.data = new byte[answer[idx++]];
            for(int i = 0; i < res.data.Length; i++)
            {
                res.data[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_hardware_i2c_read_rsp_t ble_cmd_hardware_i2c_read(int address, int stop, int length)
        {
            log("ble_cmd_hardware_i2c_read_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_i2c_read_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)stop;
            m_tx[idx++] = (byte)length;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_i2c_read_rsp_t res = new ble_msg_hardware_i2c_read_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            res.data = new byte[answer[idx++]];
            for(int i = 0; i < res.data.Length; i++)
            {
                res.data[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_hardware_i2c_write_rsp_t ble_cmd_hardware_i2c_write(int address, int stop, byte[] data)
        {
            log("ble_cmd_hardware_i2c_write_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1 + data.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_i2c_write_id;
            // data
            m_tx[idx++] = (byte)address;
            m_tx[idx++] = (byte)stop;
            m_tx[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                m_tx[idx++] = data[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1 + data.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_i2c_write_rsp_t res = new ble_msg_hardware_i2c_write_rsp_t();
            res.written = answer[idx++];
            return res;
        }

        public void ble_cmd_hardware_set_txpower(int power)
        {
            log("ble_cmd_hardware_set_txpower_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_set_txpower_id;
            // data
            m_tx[idx++] = (byte)power;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
        }

        public ble_msg_hardware_timer_comparator_rsp_t ble_cmd_hardware_timer_comparator(int timer, int channel, int mode, int comparator_value)
        {
            log("ble_cmd_hardware_timer_comparator_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1 + 2);
            m_tx[idx++] = (byte)ble_classes.ble_cls_hardware;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_hardware_timer_comparator_id;
            // data
            m_tx[idx++] = (byte)timer;
            m_tx[idx++] = (byte)channel;
            m_tx[idx++] = (byte)mode;
            m_tx[idx++] = (byte)comparator_value;
            m_tx[idx++] = (byte)(comparator_value >> 8);
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1 + 2, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_hardware_timer_comparator_rsp_t res = new ble_msg_hardware_timer_comparator_rsp_t();
            res.result = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_test_phy_tx(int channel, int length, int type)
        {
            log("ble_cmd_test_phy_tx_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + 1 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_tx_id;
            // data
            m_tx[idx++] = (byte)channel;
            m_tx[idx++] = (byte)length;
            m_tx[idx++] = (byte)type;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + 1 + 1, false);
        }

        public void ble_cmd_test_phy_rx(int channel)
        {
            log("ble_cmd_test_phy_rx_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_rx_id;
            // data
            m_tx[idx++] = (byte)channel;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1, false);
        }

        public ble_msg_test_phy_end_rsp_t ble_cmd_test_phy_end()
        {
            log("ble_cmd_test_phy_end_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_end_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_test_phy_end_rsp_t res = new ble_msg_test_phy_end_rsp_t();
            res.counter = answer[idx+0] | (answer[idx+1] << 8); idx+=2;
            return res;
        }

        public void ble_cmd_test_phy_reset()
        {
            log("ble_cmd_test_phy_reset_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_reset_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
        }

        public ble_msg_test_get_channel_map_rsp_t ble_cmd_test_get_channel_map()
        {
            log("ble_cmd_test_get_channel_map_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_get_channel_map_id;
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_test_get_channel_map_rsp_t res = new ble_msg_test_get_channel_map_rsp_t();
            res.channel_map = new byte[answer[idx++]];
            for(int i = 0; i < res.channel_map.Length; i++)
            {
                res.channel_map[i] = answer[idx++];
            }
            return res;
        }

        public ble_msg_test_debug_rsp_t ble_cmd_test_debug(byte[] input)
        {
            log("ble_cmd_test_debug_id");
            int idx = 0;
            // header
            m_tx[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            m_tx[idx++] = (byte)(0 + 1 + input.Length);
            m_tx[idx++] = (byte)ble_classes.ble_cls_test;
            m_tx[idx++] = (byte)ble_command_ids.ble_cmd_test_debug_id;
            // data
            m_tx[idx++] = (byte)(input.Length);
            for(int i = 0; i < input.Length; i++)
            {
                m_tx[idx++] = input[i];
            }
            // send
            byte[] answer = Send(m_tx, 0, SIZE_HEADER /* header */ + 0 + 1 + input.Length, false);
            // parse answer
            idx = SIZE_HEADER;
            ble_msg_test_debug_rsp_t res = new ble_msg_test_debug_rsp_t();
            res.output = new byte[answer[idx++]];
            for(int i = 0; i < res.output.Length; i++)
            {
                res.output[i] = answer[idx++];
            }
            return res;
        }

        public class ble_msg_system_boot_evt_t
        {
            public int major;
            public int minor;
            public int patch;
            public int build;
            public int ll_version;
            public int protocol_version;
            public int hw;
        }

        public class ble_msg_system_debug_evt_t
        {
            public byte[] data;
        }

        public class ble_msg_system_endpoint_watermark_rx_evt_t
        {
            public int endpoint;
            public int data;
        }

        public class ble_msg_system_endpoint_watermark_tx_evt_t
        {
            public int endpoint;
            public int data;
        }

        public class ble_msg_system_script_failure_evt_t
        {
            public int address;
            public int reason;
        }

        public class ble_msg_flash_ps_key_evt_t
        {
            public int key;
            public byte[] value;
        }

        public class ble_msg_attributes_value_evt_t
        {
            public int connection;
            public int reason;
            public int handle;
            public int offset;
            public byte[] value;
        }

        public class ble_msg_attributes_user_read_request_evt_t
        {
            public int connection;
            public int handle;
            public int offset;
            public int maxsize;
        }

        public class ble_msg_attributes_status_evt_t
        {
            public int handle;
            public int flags;
        }

        public class ble_msg_connection_status_evt_t
        {
            public int connection;
            public int flags;
            public bd_addr address;
            public int address_type;
            public int conn_interval;
            public int timeout;
            public int latency;
            public int bonding;
        }

        public class ble_msg_connection_version_ind_evt_t
        {
            public int connection;
            public int vers_nr;
            public int comp_id;
            public int sub_vers_nr;
        }

        public class ble_msg_connection_feature_ind_evt_t
        {
            public int connection;
            public byte[] features;
        }

        public class ble_msg_connection_raw_rx_evt_t
        {
            public int connection;
            public byte[] data;
        }

        public class ble_msg_connection_disconnected_evt_t
        {
            public int connection;
            public int reason;
        }

        public class ble_msg_attclient_indicated_evt_t
        {
            public int connection;
            public int attrhandle;
        }

        public class ble_msg_attclient_procedure_completed_evt_t
        {
            public int connection;
            public int result;
            public int chrhandle;
        }

        public class ble_msg_attclient_group_found_evt_t
        {
            public int connection;
            public int start;
            public int end;
            public byte[] uuid;
        }

        public class ble_msg_attclient_attribute_found_evt_t
        {
            public int connection;
            public int chrdecl;
            public int value;
            public int properties;
            public byte[] uuid;
        }

        public class ble_msg_attclient_find_information_found_evt_t
        {
            public int connection;
            public int chrhandle;
            public byte[] uuid;
        }

        public class ble_msg_attclient_attribute_value_evt_t
        {
            public int connection;
            public int atthandle;
            public int type;
            public byte[] value;
        }

        public class ble_msg_attclient_read_multiple_response_evt_t
        {
            public int connection;
            public byte[] handles;
        }

        public class ble_msg_sm_smp_data_evt_t
        {
            public int handle;
            public int packet;
            public byte[] data;
        }

        public class ble_msg_sm_bonding_fail_evt_t
        {
            public int handle;
            public int result;
        }

        public class ble_msg_sm_passkey_display_evt_t
        {
            public int handle;
            public int passkey;
        }

        public class ble_msg_sm_passkey_request_evt_t
        {
            public int handle;
        }

        public class ble_msg_sm_bond_status_evt_t
        {
            public int bond;
            public int keysize;
            public int mitm;
            public int keys;
        }

        public class ble_msg_gap_scan_response_evt_t
        {
            public int rssi;
            public int packet_type;
            public bd_addr sender;
            public int address_type;
            public int bond;
            public byte[] data;
        }

        public class ble_msg_gap_mode_changed_evt_t
        {
            public int discover;
            public int connect;
        }

        public class ble_msg_hardware_io_port_status_evt_t
        {
            public int timestamp;
            public int port;
            public int irq;
            public int state;
        }

        public class ble_msg_hardware_soft_timer_evt_t
        {
            public int handle;
        }

        public class ble_msg_hardware_adc_result_evt_t
        {
            public int input;
            public int value;
        }

        protected virtual void ble_evt_system_boot(ble_msg_system_boot_evt_t arg)
        {
            log("ble_evt_system_boot");
        }

        protected virtual void ble_evt_system_debug(ble_msg_system_debug_evt_t arg)
        {
            log("ble_evt_system_debug");
        }

        protected virtual void ble_evt_system_endpoint_watermark_rx(ble_msg_system_endpoint_watermark_rx_evt_t arg)
        {
            log("ble_evt_system_endpoint_watermark_rx");
        }

        protected virtual void ble_evt_system_endpoint_watermark_tx(ble_msg_system_endpoint_watermark_tx_evt_t arg)
        {
            log("ble_evt_system_endpoint_watermark_tx");
        }

        protected virtual void ble_evt_system_script_failure(ble_msg_system_script_failure_evt_t arg)
        {
            log("ble_evt_system_script_failure");
        }

        protected virtual void ble_evt_flash_ps_key(ble_msg_flash_ps_key_evt_t arg)
        {
            log("ble_evt_flash_ps_key");
        }

        protected virtual void ble_evt_attributes_value(ble_msg_attributes_value_evt_t arg)
        {
            log("ble_evt_attributes_value");
        }

        protected virtual void ble_evt_attributes_user_read_request(ble_msg_attributes_user_read_request_evt_t arg)
        {
            log("ble_evt_attributes_user_read_request");
        }

        protected virtual void ble_evt_attributes_status(ble_msg_attributes_status_evt_t arg)
        {
            log("ble_evt_attributes_status");
        }

        protected virtual void ble_evt_connection_status(ble_msg_connection_status_evt_t arg)
        {
            log("ble_evt_connection_status");
        }

        protected virtual void ble_evt_connection_version_ind(ble_msg_connection_version_ind_evt_t arg)
        {
            log("ble_evt_connection_version_ind");
        }

        protected virtual void ble_evt_connection_feature_ind(ble_msg_connection_feature_ind_evt_t arg)
        {
            log("ble_evt_connection_feature_ind");
        }

        protected virtual void ble_evt_connection_raw_rx(ble_msg_connection_raw_rx_evt_t arg)
        {
            log("ble_evt_connection_raw_rx");
        }

        protected virtual void ble_evt_connection_disconnected(ble_msg_connection_disconnected_evt_t arg)
        {
            log("ble_evt_connection_disconnected");
        }

        protected virtual void ble_evt_attclient_indicated(ble_msg_attclient_indicated_evt_t arg)
        {
            log("ble_evt_attclient_indicated");
        }

        protected virtual void ble_evt_attclient_procedure_completed(ble_msg_attclient_procedure_completed_evt_t arg)
        {
            log("ble_evt_attclient_procedure_completed");
        }

        protected virtual void ble_evt_attclient_group_found(ble_msg_attclient_group_found_evt_t arg)
        {
            log("ble_evt_attclient_group_found");
        }

        protected virtual void ble_evt_attclient_attribute_found(ble_msg_attclient_attribute_found_evt_t arg)
        {
            log("ble_evt_attclient_attribute_found");
        }

        protected virtual void ble_evt_attclient_find_information_found(ble_msg_attclient_find_information_found_evt_t arg)
        {
            log("ble_evt_attclient_find_information_found");
        }

        protected virtual void ble_evt_attclient_attribute_value(ble_msg_attclient_attribute_value_evt_t arg)
        {
            log("ble_evt_attclient_attribute_value");
        }

        protected virtual void ble_evt_attclient_read_multiple_response(ble_msg_attclient_read_multiple_response_evt_t arg)
        {
            log("ble_evt_attclient_read_multiple_response");
        }

        protected virtual void ble_evt_sm_smp_data(ble_msg_sm_smp_data_evt_t arg)
        {
            log("ble_evt_sm_smp_data");
        }

        protected virtual void ble_evt_sm_bonding_fail(ble_msg_sm_bonding_fail_evt_t arg)
        {
            log("ble_evt_sm_bonding_fail");
        }

        protected virtual void ble_evt_sm_passkey_display(ble_msg_sm_passkey_display_evt_t arg)
        {
            log("ble_evt_sm_passkey_display");
        }

        protected virtual void ble_evt_sm_passkey_request(ble_msg_sm_passkey_request_evt_t arg)
        {
            log("ble_evt_sm_passkey_request");
        }

        protected virtual void ble_evt_sm_bond_status(ble_msg_sm_bond_status_evt_t arg)
        {
            log("ble_evt_sm_bond_status");
        }

        protected virtual void ble_evt_gap_scan_response(ble_msg_gap_scan_response_evt_t arg)
        {
            log("ble_evt_gap_scan_response");
        }

        protected virtual void ble_evt_gap_mode_changed(ble_msg_gap_mode_changed_evt_t arg)
        {
            log("ble_evt_gap_mode_changed");
        }

        protected virtual void ble_evt_hardware_io_port_status(ble_msg_hardware_io_port_status_evt_t arg)
        {
            log("ble_evt_hardware_io_port_status");
        }

        protected virtual void ble_evt_hardware_soft_timer(ble_msg_hardware_soft_timer_evt_t arg)
        {
            log("ble_evt_hardware_soft_timer");
        }

        protected virtual void ble_evt_hardware_adc_result(ble_msg_hardware_adc_result_evt_t arg)
        {
            log("ble_evt_hardware_adc_result");
        }

        protected void handleEvent(byte[] buffer)
        {
            int idx = SIZE_HEADER;
            int _length = ((buffer[0] & 0x7F) << 8) | buffer[1];
            switch(buffer[2])
            {
                case (byte)ble_classes.ble_cls_system:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_system_boot_id:
                            {
                                ble_msg_system_boot_evt_t s = new ble_msg_system_boot_evt_t();
                                s.major = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.minor = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.patch = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.build = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.ll_version = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.protocol_version = buffer[idx++];
                                s.hw = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_system_boot(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_system_debug_id:
                            {
                                ble_msg_system_debug_evt_t s = new ble_msg_system_debug_evt_t();
                                s.data = new byte[buffer[idx++]];
                                for(int i = 0; i < s.data.Length; i++)
                                {
                                    s.data[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_system_debug(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_system_endpoint_watermark_rx_id:
                            {
                                ble_msg_system_endpoint_watermark_rx_evt_t s = new ble_msg_system_endpoint_watermark_rx_evt_t();
                                s.endpoint = buffer[idx++];
                                s.data = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_system_endpoint_watermark_rx(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_system_endpoint_watermark_tx_id:
                            {
                                ble_msg_system_endpoint_watermark_tx_evt_t s = new ble_msg_system_endpoint_watermark_tx_evt_t();
                                s.endpoint = buffer[idx++];
                                s.data = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_system_endpoint_watermark_tx(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_system_script_failure_id:
                            {
                                ble_msg_system_script_failure_evt_t s = new ble_msg_system_script_failure_evt_t();
                                s.address = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.reason = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_system_script_failure(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_flash:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_flash_ps_key_id:
                            {
                                ble_msg_flash_ps_key_evt_t s = new ble_msg_flash_ps_key_evt_t();
                                s.key = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.value = new byte[buffer[idx++]];
                                for(int i = 0; i < s.value.Length; i++)
                                {
                                    s.value[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_flash_ps_key(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_attributes:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_attributes_value_id:
                            {
                                ble_msg_attributes_value_evt_t s = new ble_msg_attributes_value_evt_t();
                                s.connection = buffer[idx++];
                                s.reason = buffer[idx++];
                                s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.offset = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.value = new byte[buffer[idx++]];
                                for(int i = 0; i < s.value.Length; i++)
                                {
                                    s.value[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attributes_value(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attributes_user_read_request_id:
                            {
                                ble_msg_attributes_user_read_request_evt_t s = new ble_msg_attributes_user_read_request_evt_t();
                                s.connection = buffer[idx++];
                                s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.offset = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.maxsize = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attributes_user_read_request(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attributes_status_id:
                            {
                                ble_msg_attributes_status_evt_t s = new ble_msg_attributes_status_evt_t();
                                s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.flags = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attributes_status(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_connection:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_connection_status_id:
                            {
                                ble_msg_connection_status_evt_t s = new ble_msg_connection_status_evt_t();
                                s.connection = buffer[idx++];
                                s.flags = buffer[idx++];
                                s.address = new bd_addr();
                                for(int i = 0; i < s.address.Length; i++)
                                {
                                    s.address.Address[i] = buffer[idx++];
                                }
                                s.address_type = buffer[idx++];
                                s.conn_interval = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.timeout = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.latency = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.bonding = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_connection_status(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_connection_version_ind_id:
                            {
                                ble_msg_connection_version_ind_evt_t s = new ble_msg_connection_version_ind_evt_t();
                                s.connection = buffer[idx++];
                                s.vers_nr = buffer[idx++];
                                s.comp_id = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.sub_vers_nr = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_connection_version_ind(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_connection_feature_ind_id:
                            {
                                ble_msg_connection_feature_ind_evt_t s = new ble_msg_connection_feature_ind_evt_t();
                                s.connection = buffer[idx++];
                                s.features = new byte[buffer[idx++]];
                                for(int i = 0; i < s.features.Length; i++)
                                {
                                    s.features[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_connection_feature_ind(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_connection_raw_rx_id:
                            {
                                ble_msg_connection_raw_rx_evt_t s = new ble_msg_connection_raw_rx_evt_t();
                                s.connection = buffer[idx++];
                                s.data = new byte[buffer[idx++]];
                                for(int i = 0; i < s.data.Length; i++)
                                {
                                    s.data[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_connection_raw_rx(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_connection_disconnected_id:
                            {
                                ble_msg_connection_disconnected_evt_t s = new ble_msg_connection_disconnected_evt_t();
                                s.connection = buffer[idx++];
                                s.reason = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_connection_disconnected(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_attclient:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_attclient_indicated_id:
                            {
                                ble_msg_attclient_indicated_evt_t s = new ble_msg_attclient_indicated_evt_t();
                                s.connection = buffer[idx++];
                                s.attrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_indicated(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_procedure_completed_id:
                            {
                                ble_msg_attclient_procedure_completed_evt_t s = new ble_msg_attclient_procedure_completed_evt_t();
                                s.connection = buffer[idx++];
                                s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.chrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_procedure_completed(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_group_found_id:
                            {
                                ble_msg_attclient_group_found_evt_t s = new ble_msg_attclient_group_found_evt_t();
                                s.connection = buffer[idx++];
                                s.start = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.end = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.uuid = new byte[buffer[idx++]];
                                for(int i = 0; i < s.uuid.Length; i++)
                                {
                                    s.uuid[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_group_found(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_attribute_found_id:
                            {
                                ble_msg_attclient_attribute_found_evt_t s = new ble_msg_attclient_attribute_found_evt_t();
                                s.connection = buffer[idx++];
                                s.chrdecl = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.value = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.properties = buffer[idx++];
                                s.uuid = new byte[buffer[idx++]];
                                for(int i = 0; i < s.uuid.Length; i++)
                                {
                                    s.uuid[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_attribute_found(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_find_information_found_id:
                            {
                                ble_msg_attclient_find_information_found_evt_t s = new ble_msg_attclient_find_information_found_evt_t();
                                s.connection = buffer[idx++];
                                s.chrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.uuid = new byte[buffer[idx++]];
                                for(int i = 0; i < s.uuid.Length; i++)
                                {
                                    s.uuid[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_find_information_found(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_attribute_value_id:
                            {
                                ble_msg_attclient_attribute_value_evt_t s = new ble_msg_attclient_attribute_value_evt_t();
                                s.connection = buffer[idx++];
                                s.atthandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                s.type = buffer[idx++];
                                s.value = new byte[buffer[idx++]];
                                for(int i = 0; i < s.value.Length; i++)
                                {
                                    s.value[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_attribute_value(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_attclient_read_multiple_response_id:
                            {
                                ble_msg_attclient_read_multiple_response_evt_t s = new ble_msg_attclient_read_multiple_response_evt_t();
                                s.connection = buffer[idx++];
                                s.handles = new byte[buffer[idx++]];
                                for(int i = 0; i < s.handles.Length; i++)
                                {
                                    s.handles[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_attclient_read_multiple_response(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_sm:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_sm_smp_data_id:
                            {
                                ble_msg_sm_smp_data_evt_t s = new ble_msg_sm_smp_data_evt_t();
                                s.handle = buffer[idx++];
                                s.packet = buffer[idx++];
                                s.data = new byte[buffer[idx++]];
                                for(int i = 0; i < s.data.Length; i++)
                                {
                                    s.data[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_sm_smp_data(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_sm_bonding_fail_id:
                            {
                                ble_msg_sm_bonding_fail_evt_t s = new ble_msg_sm_bonding_fail_evt_t();
                                s.handle = buffer[idx++];
                                s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_sm_bonding_fail(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_sm_passkey_display_id:
                            {
                                ble_msg_sm_passkey_display_evt_t s = new ble_msg_sm_passkey_display_evt_t();
                                s.handle = buffer[idx++];
                                s.passkey = buffer[idx+0] | (buffer[idx+1] << 8) | (buffer[idx+2] << 16) | (buffer[idx+3] << 24); idx+=4;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_sm_passkey_display(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_sm_passkey_request_id:
                            {
                                ble_msg_sm_passkey_request_evt_t s = new ble_msg_sm_passkey_request_evt_t();
                                s.handle = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_sm_passkey_request(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_sm_bond_status_id:
                            {
                                ble_msg_sm_bond_status_evt_t s = new ble_msg_sm_bond_status_evt_t();
                                s.bond = buffer[idx++];
                                s.keysize = buffer[idx++];
                                s.mitm = buffer[idx++];
                                s.keys = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_sm_bond_status(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_gap:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_gap_scan_response_id:
                            {
                                ble_msg_gap_scan_response_evt_t s = new ble_msg_gap_scan_response_evt_t();
                                s.rssi = buffer[idx++];
                                s.packet_type = buffer[idx++];
                                s.sender = new bd_addr();
                                for(int i = 0; i < s.sender.Length; i++)
                                {
                                    s.sender.Address[i] = buffer[idx++];
                                }
                                s.address_type = buffer[idx++];
                                s.bond = buffer[idx++];
                                s.data = new byte[buffer[idx++]];
                                for(int i = 0; i < s.data.Length; i++)
                                {
                                    s.data[i] = buffer[idx++];
                                }
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_gap_scan_response(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_gap_mode_changed_id:
                            {
                                ble_msg_gap_mode_changed_evt_t s = new ble_msg_gap_mode_changed_evt_t();
                                s.discover = buffer[idx++];
                                s.connect = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_gap_mode_changed(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_hardware:
                    switch(buffer[3])
                    {
                        case (byte)ble_event_ids.ble_evt_hardware_io_port_status_id:
                            {
                                ble_msg_hardware_io_port_status_evt_t s = new ble_msg_hardware_io_port_status_evt_t();
                                s.timestamp = buffer[idx+0] | (buffer[idx+1] << 8) | (buffer[idx+2] << 16) | (buffer[idx+3] << 24); idx+=4;
                                s.port = buffer[idx++];
                                s.irq = buffer[idx++];
                                s.state = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_hardware_io_port_status(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_hardware_soft_timer_id:
                            {
                                ble_msg_hardware_soft_timer_evt_t s = new ble_msg_hardware_soft_timer_evt_t();
                                s.handle = buffer[idx++];
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_hardware_soft_timer(s);
                            }
                            break;
                        case (byte)ble_event_ids.ble_evt_hardware_adc_result_id:
                            {
                                ble_msg_hardware_adc_result_evt_t s = new ble_msg_hardware_adc_result_evt_t();
                                s.input = buffer[idx++];
                                s.value = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                check(idx, SIZE_HEADER + _length);
                                ble_evt_hardware_adc_result(s);
                            }
                            break;
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                case (byte)ble_classes.ble_cls_test:
                    switch(buffer[3])
                    {
                        default:
                            throw new BLE112Exception(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                    }
                    break;
                default:
                    throw new BLE112Exception(string.Format("Unknown class 0x{0}", buffer[2].ToString("X2")));
            }
        }
    }
}