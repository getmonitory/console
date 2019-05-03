import {
	http
} from 'utils/http';

const MonitoringService = {
	async list () {
		var result = await http.get('/api/v1/monitoring');
		if (result.status === 200) {
			return result.data;
		} else {
			console.error(result.error);
			throw result.error;
		}
	},

	async save (model) {
		var result = await http.post('/api/v1/monitoring', model);
		if (result.status === 200) {
			return result.data;
		} else {
			console.error(result.error);
			throw result.error;
		}
	}
};

export default MonitoringService;
