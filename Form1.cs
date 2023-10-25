using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace 카카오맵_API
{
    public partial class Form1 : Form
    {
        private string selectedAddress;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            listView_kakao.Items.Clear(); // 기존 항목 지우기
            string keyword = tbox_search.Text; // 텍스트 상자에서 사용자의 입력을 가져옵니다.

            string apiKey = "79f86b66887045842d041131f5dcfe3a";
            string apiUrl = $"https://dapi.kakao.com/v2/local/search/keyword.json?query={keyword}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"KakaoAK {apiKey}");

                HttpResponseMessage response = client.GetAsync(apiUrl).Result; // 동기적 호출 사용

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    // JSON을 파싱하여 결과를 리스트뷰에 표시
                    dynamic result = JsonConvert.DeserializeObject(json);

                    foreach (var place in result.documents)
                    {
                        string placeName = place.place_name;
                        string addressName = place.address_name;

                        // 리스트뷰에 결과 추가
                        listView_kakao.Items.Add(new ListViewItem(new[] { placeName, addressName }));
                    }
                }
                else
                {
                    // 오류 처리
                    MessageBox.Show("API 호출 중 오류가 발생했습니다.");
                }
            }
        }

        private void listView_kakao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_kakao.SelectedItems.Count > 0)
            {
                // 선택한 항목의 첫 번째 서브아이템(주소)에서 URL 추출
                string selectedAddress = listView_kakao.SelectedItems[0].SubItems[1].Text;

                // URL을 웹 브라우저에 표시
                webBrowser1.Navigate(selectedAddress);
            }
        }
    }
}
