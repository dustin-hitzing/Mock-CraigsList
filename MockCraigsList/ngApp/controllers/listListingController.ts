namespace MockCraigsList.Controllers {
    export class ListListingController {
        public listings;
        constructor(private $http) {
            $http.get('/api/listings')
                .then((response) => {
                    this.listings = response.data;
                })

            
        }

    }
}